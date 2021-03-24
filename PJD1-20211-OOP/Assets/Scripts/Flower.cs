using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : PowerUp
{
    private void Awake()
    {
        Type = PowerUpType.Flower;
        Points = 1200;
        PowerUpName = "Flower";
    }
}
