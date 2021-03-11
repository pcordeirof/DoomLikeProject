using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[InlineEditor]
[CreateAssetMenu(fileName = "EnemyPossiblesPositions", menuName = "Enemy/EnemyPossiblesPositions")]
public class PossiblesPositions: ScriptableObject
{
    public List<Vector3> EnemyPossiblesPositions = new List<Vector3>();
    public FloatVariable Height;

    [Button("Add Position")]
    public void AddPositon(float x,  float z)
    {
        Vector3 position = new Vector3(x, Height.Value, z);
        if (!EnemyPossiblesPositions.Contains(position))
        {
            EnemyPossiblesPositions.Add(position);
        }
    }

    [Button("Remove Position")]
    public void RemovePositon(float x, float z)
    {
        Vector3 position = new Vector3(x, Height.Value, z);
        while(EnemyPossiblesPositions.Contains(position))
        {
            EnemyPossiblesPositions.Remove(position);
        }
    }

    [Button("Clean Positions")]
    public void CleanPositions()
    {
        EnemyPossiblesPositions.Clear();
    }
}
