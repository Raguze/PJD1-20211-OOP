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

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
    }
}
