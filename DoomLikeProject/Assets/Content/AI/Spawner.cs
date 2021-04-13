using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PossiblesPositions possiblesPositions;
    public bool spawnDuringStart;
    public FloatVariable numberOfEnemies;
    public List<GameObject> enemyList = new List<GameObject>();
    public FloatVariable Wave;
    public Text waveText;
    public AudioManager audioManager;

    void Start()
    {
        Wave.Value = 1;
        waveText.text = Wave.Value.ToString();
        if (spawnDuringStart)
        {
            SpawnEnemies();    
        }
    }
    void Update()
    {
        if (spawnDuringStart)
        {
            CheckList();
        }
    }

    [Button("Spawn New Enemy")]
    void SpawnNewEnemy()
    {
        GameObject newEnemy;
        newEnemy = Instantiate(enemyPrefab, possiblesPositions.EnemyPossiblesPositions[Random.Range(0 , possiblesPositions.EnemyPossiblesPositions.Count)], Quaternion.identity);
        enemyList.Add(newEnemy);
    }

    void SpawnEnemies()
    {
        numberOfEnemies.Value = Wave.Value;
        for (int i = 0; i < (int)numberOfEnemies.Value; i++)
        {
            SpawnNewEnemy();
        }
    }
    void CheckList()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            if(enemyList[i] == null)
            {
                enemyList.RemoveAt(i);
            }
        }

        if(enemyList.Count == 0)
        {
            Wave.Value++;
            waveText.text = Wave.Value.ToString();
            audioManager.ChangeVelocity("WaveTomJobim", Wave.Value);
            SpawnEnemies();
        }
    }
}
