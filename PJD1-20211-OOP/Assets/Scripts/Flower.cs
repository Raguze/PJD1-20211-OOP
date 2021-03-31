using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : PowerUp
{
    protected override void Awake()
    {
        base.Awake();

        Type = PowerUpType.Flower;
        Points = 1200;
        PowerUpName = "Flower";
    }

    public override void Move()
    {
        
    }
}
