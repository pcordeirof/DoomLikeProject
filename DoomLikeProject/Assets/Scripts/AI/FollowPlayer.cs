using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FollowPlayer : MonoBehaviour
{
    public PlayerPosition playerPosition;
    public NavMeshAgent agent;
  
    void Update()
    {
        agent.destination = playerPosition.position;
    }
}
