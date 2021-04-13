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
    public Transform cameraTransform;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            handGunAnimator.SetTrigger("Shot");
        }
    }

    public void Shot()
    {
        audioManager.PlayOneShot("GunShotSFX");
        aimTransform.DOShakePosition(.5f, vibrato: 100, strength: new Vector3(10, 10, 0));
        cameraTransform.DOShakeRotation(.1f, strength: new Vector3(0, 0, 5));
        shot.State = false;

    }
}
