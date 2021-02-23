using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Transform playerTransform;

    void Update()
    {
        Vector3 target = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z);
        transform.LookAt(target);
    }
}
