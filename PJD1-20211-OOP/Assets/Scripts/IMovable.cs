using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IMovable
{
    float DirectionX { get; set; }
    float Speed { get; set; }
    void Move();
}
