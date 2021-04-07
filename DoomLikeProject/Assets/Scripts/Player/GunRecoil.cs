using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GunRecoil : MonoBehaviour
{
    public Animator handGunAnimator;
    public BoolVariable shot;
    public AudioManager audioManager;
    public Transform aimTransform;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            handGunAnimator.SetTrigger("Shot");
        }
        else
        {
            shot.State = false;
        }
    }

    public void Shot()
    {
        shot.State = true;
        audioManager.PlayOneShot("GunShotSFX");
        aimTransform.DOShakePosition(.5f,vibrato: 100, strength: new Vector3(10, 10, 0));
    }

}
