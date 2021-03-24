using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : TimedPowerUp
{
    private void Awake()
    {
        Type = PowerUpType.Star;
        Points = 8000;
        PowerUpName = "Star";
        Duration = 2f;
    }
}
