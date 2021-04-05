using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GunRecoil : MonoBehaviour
{
    public Animator handGunAnimator;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            handGunAnimator.SetTrigger("Shot");
        }
    }

}
