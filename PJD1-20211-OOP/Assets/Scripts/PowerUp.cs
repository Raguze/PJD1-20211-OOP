using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PowerUpType { None, Mushroom, Flower, Star, Life, Poison }

[System.Serializable]
public class PowerUp : Triggable
{
    public PowerUpType Type { get; protected set; }

    public int Points { get; protected set; }
    
    public string PowerUpName { get; protected set; }

    public string DebugString
    {
        get { return PowerUpName + " type: " + Type + " points: " + Points; }
    }
}
