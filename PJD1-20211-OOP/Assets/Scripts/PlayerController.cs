using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerController : MonoBehaviour
{
    // Components
    Rigidbody2D rb;

    // Dados
    float jumpForce;
    float runSpeed;
    float walkSpeed;

    //static public string StaticName;

    string playerName;

    bool hasStar;
    float starTime;

    public PowerUpType PowerUp { get; set; }

    public PowerUpType TimedPowerUp { get; set; }

    public int Coins { get; set; }
    public int Life { get; set; }
    public int Points { get; set; }

    public float Horizontal { get; set; }

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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 rbVelocity = rb.velocity;
        rbVelocity.x = Horizontal;
        rb.velocity = rbVelocity;
    }

}
