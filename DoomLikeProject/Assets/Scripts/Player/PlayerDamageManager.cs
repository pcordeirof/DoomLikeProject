using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageManager : MonoBehaviour
{
    public FloatVariable playerHP;
    public FloatVariable playerMaxHP;

    private void Start()
    {
        playerHP.Value = playerMaxHP.Value;
    }

    public void DecreaseHP()
    {
        playerHP.Value -= .5f;
        Debug.Log(playerHP.Value);

        if(playerHP.Value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
