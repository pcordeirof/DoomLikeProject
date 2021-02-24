using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FollowPlayer : MonoBehaviour
{
    public NavMeshAgent agent;
    public FloatVariable baseOfsset;
    public bool isFlying;
    public PlayerPosition playerPosition;

    void Start()
    {
        if (isFlying)
        {
            agent.baseOffset = baseOfsset.Value;
        }  
    }

    
    void Update()
    {
        agent.destination = playerPosition.position;
    }
}
