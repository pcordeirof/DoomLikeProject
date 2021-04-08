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
    bool isDead;

    private void Start()
    {
        playerHP.Value = playerMaxHP.Value;
        slider.maxValue = playerMaxHP.Value;
        slider.value = playerMaxHP.Value;
        isDead = false; 
    }

    public void DecreaseHP()
    {
        if (!isDead)
        {
            playerHP.Value -= damageAmountTaken.Value;
            //Debug.Log("PlayerHPValue: " + playerHP.Value);
        }

        if(playerHP.Value <= 0)
        {
            isDead = true;
        }
    }

    public void ChangeHPBar()
    {
        slider.value = playerHP.Value;
        if(slider.value <= 0)
        {
            Time.timeScale = 0;
        }
        //Debug.Log("SliderHPValue: " + slider.value);
    }
}
