using CodeMonkey.Utils;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SoldierAttack : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    private UnitRTS unitRTS;
    public GameObject target;
    public Vector2 moveDir;
    private Bullet bulletTarget;
    BuildingManager buildingManager;



    private void Start()
    {
        unitRTS= GetComponent<UnitRTS>();
        buildingManager= GetComponent<BuildingManager>();
        bulletTarget = bullet.GetComponent<Bullet>();
    }

    [System.Obsolete]
    private void Update()
    {
        if(Input.GetMouseButtonDown(2) && unitRTS.selectedGameObject.active) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null) {
                Debug.Log("Tiklanan objenin adı: " + target);

                if (bulletTarget != null) {
                    target = GameObject.Find(hit.collider.gameObject.name);
                    bulletTarget.target = target;
                }
                Debug.Log(moveDir);
                Instantiate(bullet, transform.position, Quaternion.identity);
            }   
        }
    }
}
