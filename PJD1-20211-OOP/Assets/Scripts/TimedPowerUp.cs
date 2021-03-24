using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class OnPowerUpTimerEnd : UnityEvent<TimedPowerUp> { }

public class TimedPowerUp : PowerUp
{
    public OnPowerUpTimerEnd OnTimerEnd { get; protected set; }

    public float Duration { get; set; }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        OnTimerEnd = new OnPowerUpTimerEnd();
        base.OnTriggerEnter2D(collision);
    }

    public void StarTimer()
    {
        SpriteRenderer spr = gameObject.GetComponent<SpriteRenderer>();
        if(spr)
        {
            spr.enabled = false;
        }
        Collider2D collider = gameObject.GetComponent<Collider2D>();
        if(collider)
        {
            collider.enabled = false;
        }

        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        Debug.Log("Antes do Yield");
        yield return new WaitForSeconds(Duration);
        Debug.Log("Depois do Yield");

        OnTimerEnd.Invoke(this);

    }
}
