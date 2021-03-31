using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PowerUpType { None, Mushroom, Flower, Star, Life, Poison }

[System.Serializable]
public class PowerUp : Triggable, IMovable
{
    public PowerUpType Type { get; protected set; }

    public int Points { get; protected set; }
    
    public string PowerUpName { get; protected set; }

    public string DebugString
    {
        get { return PowerUpName + " type: " + Type + " points: " + Points; }
    }

    public float DirectionX { get; set; }
    public float Speed { get; set; }

    protected Rigidbody2D rb;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        Speed = 1f;
        DirectionX = 1f;
    }

    public virtual void Move()
    {
        Vector2 vel = rb.velocity;
        vel.x = Speed * DirectionX;
        rb.velocity = vel;
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player)
        {
            GameController.Instance().OnPowerUpTrigger(this);
        }
    }
}
