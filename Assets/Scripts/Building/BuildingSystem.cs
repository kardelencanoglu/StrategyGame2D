using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BuildingSystem : MonoBehaviour
{
    public GameObject[] objects;
    private GameObject pendingObject;
    private Vector3 pos;
    private RaycastHit hit;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Camera mainCamera;

    public float gridSize;

    private void Update()
    {

   
        if(pendingObject != null)
        {
            //        pendingObject.transform.position = pos;
            pendingObject.transform.position = new Vector3(
               GridPlace(pos.x),
               GridPlace(pos.y),
               GridPlace(pos.z));


            if (Input.GetMouseButtonDown(0))
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

        if(xDiff > (gridSize/2))
        {
            pos += gridSize;
        }
        return pos;
    }
}
