using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerController : MonoBehaviour
{
    // Dados
    float jumpForce;
    float runSpeed;
    float walkSpeed;

    //static public string StaticName;

    string playerName;

    bool hasStar;
    float starTime;

    public PowerUpType PowerUp { get; set; }
    public int Coins { get; set; }
    public int Life { get; set; }
    public int Points { get; set; }

    public void ShowInfo()
    {
        Debug.LogFormat("{0} possui, Coins: {1}  Life: {2}  Points: {3} PowerUp: {4}", name, Coins, Life, Points, PowerUp);
    }

    public void ShowThis()
    {
        Debug.Log(this);
    }

    // Comportamentos
    void Jump()
    {

    }

    void Run()
    {

    }

    void Walk()
    {

    }

    void Attack()
    {

    }


}
