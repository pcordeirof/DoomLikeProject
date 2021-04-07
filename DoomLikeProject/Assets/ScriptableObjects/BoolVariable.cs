using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[InlineEditor]
[CreateAssetMenu(fileName = "BoolVariable", menuName = "Variables/BoolVariable")]
public class BoolVariable : ScriptableObject
{
    public bool State;
}
