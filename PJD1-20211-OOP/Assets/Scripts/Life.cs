using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : PowerUp
{
    private void Awake()
    {
        Type = PowerUpType.Life;
        Points = 5000;
        PowerUpName = "Life";
    }
}
