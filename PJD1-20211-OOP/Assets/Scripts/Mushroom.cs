using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : PowerUp
{
    protected override void Awake()
    {
        base.Awake();

        Type = PowerUpType.Mushroom;
        Points = 800;
        PowerUpName = "Mushroom";

        Speed = 0.2f;
        DirectionX = 1f;
    }
}
