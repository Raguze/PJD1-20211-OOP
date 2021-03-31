using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : PowerUp
{
    protected override void Awake()
    {
        base.Awake();
        Type = PowerUpType.Life;
        Points = 5000;
        PowerUpName = "Life";
    }
}
