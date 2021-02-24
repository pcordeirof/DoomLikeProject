using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "PlayerPosition", menuName = "Player/PlayerPosition")]
public class PlayerPosition : ScriptableObject
{
    public Vector3 position;
    public GameObject player;
    private void Awake()
    {
        position = player.transform.position;
    }
}
