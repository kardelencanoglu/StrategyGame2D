using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using CodeMonkey.Utils;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject pendingObject;
    private Vector3 pos;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Camera mainCamera;
    public float gridSize;

    public bool canPlace = true;

    public bool isSelect = false;
    public bool isBarracks = false;


    private void Start()
    {

    }

    private void Update()
    {

        if (pendingObject != null)
        {

            pendingObject.transform.position = new Vector3(
               GridPlace(pos.x),
               GridPlace(pos.y),
               GridPlace(pos.z));


            // Debug.Log("bas1"); ##Placing the selected entity


            if (Input.GetMouseButtonDown(2) && canPlace && isSelect)
            {
                PlaceObject();
                //  Debug.Log("bas2"); ##OnClick Event
                isSelect = false;
                if (isBarracks) {
                    InvokeRepeating("GetSoldierSpawner", 3f, 3f);
                    InvokeRepeating("GetSoldier1Spawner", 3f, 6f);
                    InvokeRepeating("GetSoldier2Spawner", 3f, 8f);
                }

            }
        }

    }

    public void PlaceObject()
    {
        pendingObject = null;

       
    }

    public void GetSoldierSpawner()
    {
        SoldierSpawner.Instance.SoldierSpawn();

    }
    public void GetSoldier1Spawner() {
        SoldierSpawner.Instance.Soldier1Spawn();

    }
    public void GetSoldier2Spawner() {
        SoldierSpawner.Instance.Soldier2Spawn();

    }

    private void FixedUpdate()
    {
        Vector3 mouseWorldPosition = UtilsClass.GetMouseWorldPosition();

        pos = mouseWorldPosition;



        // Finding mouse position

    }


    public void SelectObject(int index)
    {

        pendingObject = Instantiate(objects[index], pos, transform.rotation);
        isSelect = true;
        if (index==3) {
            isBarracks = true;
        }
            //    Selected obj. values

     }



    float GridPlace(float pos)
    {
        float xDiff = pos % gridSize;
        pos -= xDiff;

        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
//S            Debug.Log("bas7");

        }

 //       Debug.Log("bas8");
        return pos;
    }
}