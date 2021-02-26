using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PossiblesPositions possiblesPositions;
    public bool spawnDuringStart;
    void Start()
    {
        if (spawnDuringStart)
        {
            for (int i = 0; i < 5; i++)
            {
                SpawnNewEnemy();
            }
        }
       
    }
    
    [Button("Spawn New Enemy")]
    void SpawnNewEnemy()
    {
        GameObject newEnemy;
        newEnemy = Instantiate(enemyPrefab, possiblesPositions.EnemyPossiblesPositions[Random.Range(0 , possiblesPositions.EnemyPossiblesPositions.Count)], Quaternion.identity);
    }
}
