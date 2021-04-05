using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HPManager : MonoBehaviour
{
    public FloatVariable maxHP;
    public Slider slider;
    public float HP;
    public TakeDamage takeDamage;

    void Start()
    {
        slider.maxValue = maxHP.Value;
        slider.value = maxHP.Value;

        HP = maxHP.Value;
    }


    public void DecreaseHP(float damageValue)
    {
        HP -= damageValue;
        slider.value = HP;
        if(HP <= 0)
        {
            takeDamage.EnemyKilled();
        }
    }
}
