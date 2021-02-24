using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public PlayerPosition playerPosition;
    public GameEvent damageEvent;
    void Update()
    {
        float distance = Vector3.Distance(playerPosition.position, transform.position);
        
        if(distance <= 2.5f)
        {
            damageEvent.Raise();
        }
    }
}
