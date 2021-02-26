using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public PlayerPosition playerPosition;

    void Update()
    {

        Vector3 target = new Vector3(playerPosition.position.x, playerPosition.position.y, playerPosition.position.z);
        transform.LookAt(target);
    }
}
