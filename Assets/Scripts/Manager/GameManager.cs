using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject[] objeler = FindObjectsOfType<GameObject>();
            foreach (GameObject obje in objeler)
            {
                Debug.Log("Objenin adı: " + obje.name);
            }
        }
    }


}
