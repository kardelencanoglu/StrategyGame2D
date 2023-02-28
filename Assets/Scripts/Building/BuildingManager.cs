using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject pendingObject;
    private Vector3 pos;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Camera mainCamera;

    CheckingPlacement placement;



    public float gridSize;

    public bool canPlace = true;

    private void Update()
    {


        if (pendingObject != null)
        {
            //        pendingObject.transform.position = pos;
            pendingObject.transform.position = new Vector3(
               GridPlace(pos.x),
               GridPlace(pos.y),
               GridPlace(pos.z));


            if (Input.GetMouseButtonDown(0) && canPlace)
            {
                PlaceObject();
            }
        }
    }

    public void PlaceObject()
    {
        pendingObject = null;
    }

    private void FixedUpdate()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;

        pos = mouseWorldPosition;

    }


    public void SelectObject(int index)
    {
        pendingObject = Instantiate(objects[index], pos, transform.rotation);
    }



    float GridPlace(float pos)
    {
        float xDiff = pos % gridSize;
        pos -= xDiff;

        if (xDiff > (gridSize / 2))
        {
            pos += gridSize;
        }
        return pos;
    }
}