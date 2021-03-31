using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : TimedPowerUp
{
    private float JumpVelocity;
    private bool shouldJump = true;

    protected override void Awake()
    {
        base.Awake();
        Type = PowerUpType.Star;
        Points = 8000;
        PowerUpName = "Star";
        Duration = 2f;
        JumpVelocity = 8f;
    }

    public override void Move()
    {
        base.Move();

        if(shouldJump)
        {
            Vector2 vel = rb.velocity;
            vel.y += JumpVelocity;
            rb.velocity = vel;
            shouldJump = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        shouldJump = true;
    }
}
