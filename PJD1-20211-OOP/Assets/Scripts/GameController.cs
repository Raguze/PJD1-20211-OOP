using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameController : MonoBehaviour
{
    public PlayerController Player;
    public PowerUp PowerUp;

    public int hp;

    static private GameController gameController;

    private float horizontal;

    private List<IMovable> movables = new List<IMovable>();

    public int movableCount;

    private void Awake()
    {
        gameController = this;

        PowerUp[] powerUps = GameObject.FindObjectsOfType<PowerUp>();
        foreach (PowerUp powerUp in powerUps)
        {
            if(powerUp is IMovable)
            {
                movables.Add(powerUp);
            }
        }
    }


    void Start()
    {

        Player = GameObject.FindObjectOfType<PlayerController>();
        Player.Coins = 8;
        Player.Life = 8;
        Player.Points = 0;


        PowerUp = GameObject.FindObjectOfType<PowerUp>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (PowerUp.Type == PowerUpType.Mushroom)
            {
                Player.Life++;
                Player.Points += PowerUp.Points;
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Player.PowerUp = PowerUpType.Star;
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        Player.Horizontal = horizontal;

        // Movables
        movableCount = movables.Count;
        foreach(IMovable movable in movables)
        {
            movable.Move();
        }
    }

    public static GameController Instance()
    {
        Debug.Log("GameController Instance");
        return gameController;
    }

    public void OnPowerUpTrigger(PowerUp powerUp)
    {
        Debug.LogFormat("OnPowerUpTrigger {0}", powerUp);
        switch (powerUp.Type)
        {
            case PowerUpType.None:
                break;
            case PowerUpType.Mushroom:
                ActionPowerUp(powerUp);
                break;
            case PowerUpType.Flower:
                ActionPowerUp(powerUp);
                break;
            case PowerUpType.Star:
                ActionTimedPowerUp(powerUp as TimedPowerUp);
                break;
            case PowerUpType.Life:
                break;
            case PowerUpType.Poison:
                break;
            default:
                break;
        }
    }

    void ActionPowerUp(PowerUp powerUp)
    {
        Player.Points += powerUp.Points;
        Player.PowerUp = powerUp.Type;
        DestroyPowerUp(powerUp);
    }

    void ActionTimedPowerUp(TimedPowerUp powerUp)
    {
        Debug.LogFormat("Action TimedPowerUp {0}", powerUp);
        Player.Points += powerUp.Points;
        Player.TimedPowerUp = powerUp.Type;
        
        powerUp.OnTimerEnd.AddListener(OnPowerUpTimerEndCallback);
        powerUp.StarTimer();
    }

    void OnPowerUpTimerEndCallback(TimedPowerUp powerUp)
    {
        Debug.Log("End Timer");
        powerUp.OnTimerEnd.RemoveAllListeners();
        Player.TimedPowerUp = PowerUpType.None;
        DestroyPowerUp(powerUp);
    }

    void DestroyPowerUp(PowerUp powerUp)
    {
        movables.Remove(powerUp);
        Destroy(powerUp.gameObject);
    }
}
