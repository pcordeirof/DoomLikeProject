using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour
{
    public FloatVariable playerHP;
    public FloatVariable playerMaxHP;
    public FloatVariable damageAmountTaken;

    private void Start()
    {
        playerHP.Value = playerMaxHP.Value;
    }

    public void DecreaseHP()
    {
        playerHP.Value -= damageAmountTaken.Value;
        Debug.Log(playerHP.Value);
        if(playerHP.Value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
