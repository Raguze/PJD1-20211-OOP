using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : PowerUp
{
    protected override void Awake()
    {
        base.Awake();
        Type = PowerUpType.Poison;
        PowerUpName = "Poison";
    }
}