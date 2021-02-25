using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public PlayerPosition playerPosition;
    public GameEvent damageEvent;
    public FloatVariable secondsToDealDamage;
    public FloatVariable damageAmountTaken;
    public FloatVariable damageAmount;
    float time = 0f;
    void FixedUpdate()
    {
        float distance = Vector3.Distance(playerPosition.position, transform.position);
     
        if(distance <= 2.5f)
        {
            time++;
        }
        else
        {
            time = 0f;
        }

        if(time % (60 * secondsToDealDamage.Value) == 0 && time !=0)
        {
            damageAmountTaken.Value = damageAmount.Value;
            damageEvent.Raise();
        }
    }
}
