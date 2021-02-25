using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshManager : MonoBehaviour
{
    public NavMeshAgent agent;
    public FloatVariable baseOfsset;
    public bool isFlying;
    public FloatVariable speed;

    void Start()
    {
        if (isFlying)
        {
            agent.baseOffset = baseOfsset.Value;
        }

        agent.speed = speed.Value;
    }

}
