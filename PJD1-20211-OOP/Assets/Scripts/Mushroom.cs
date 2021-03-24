using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : PowerUp
{
    private void Awake()
    {
        Type = PowerUpType.Mushroom;
        Points = 800;
        PowerUpName = "Mushroom";
    }
}
