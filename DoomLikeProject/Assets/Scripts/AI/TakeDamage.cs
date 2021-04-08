using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public Camera cameraMain;
    RaycastHit hitInfo = new RaycastHit();
    //public Collider enemyCollider;
    public Collider headCollider;
    public FloatVariable headDamageValue;
    public FloatVariable bodyDamageValue;
    public Collider bodyCollider;
    public HPManager hPManager;

    private void Start()
    {
        cameraMain = Camera.main;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray.origin, ray.direction, out hitInfo);
            
            if(hitInfo.collider == headCollider)
            {
                hPManager.DecreaseHP(headDamageValue.Value);
            }
            else if(hitInfo.collider == bodyCollider)
            {
                hPManager.DecreaseHP(bodyDamageValue.Value);
            }

            Debug.Log(hPManager.HP);
        }
    }

    public void EnemyKilled()
    {
        Destroy(gameObject);
    }
}
