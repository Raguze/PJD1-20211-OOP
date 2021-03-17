using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController Player;
    public PowerUp PowerUp;

    public int hp;

    // Start is called before the first frame update
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

        
    }
}
