using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamageManager : MonoBehaviour
{
    public FloatVariable playerHP;
    public FloatVariable playerMaxHP;
    public FloatVariable damageAmountTaken;
    public Slider slider;

    private void Start()
    {
        playerHP.Value = playerMaxHP.Value;
        slider.maxValue = playerMaxHP.Value;
        slider.value = playerMaxHP.Value;
    }

    public void DecreaseHP()
    {
        playerHP.Value -= damageAmountTaken.Value;
        Debug.Log("PlayerHPValue: " + playerHP.Value);
        if(playerHP.Value <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeHPBar()
    {
        slider.value = playerHP.Value;
        Debug.Log("SliderHPValue: " + slider.value);
    }
}
