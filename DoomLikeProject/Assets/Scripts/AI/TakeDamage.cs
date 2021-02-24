using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public Camera cameraMain;
    RaycastHit hitInfo = new RaycastHit();
    public Collider enemyCollider;
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
            
            if(hitInfo.collider == enemyCollider)
            {
                hPManager.DecreaseHP();
            }   
            
        }
    }

    public void EnemyKilled()
    {
        Destroy(gameObject);
    }
}
