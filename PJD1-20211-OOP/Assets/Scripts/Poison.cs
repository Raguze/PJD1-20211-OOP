using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : PowerUp
{
    private void Awake()
    {
        Type = PowerUpType.Poison;
        PowerUpName = "Poison";
    }
}