using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileHospital : MonoBehaviour
{
    [SerializeField] private GameObject _highlightHospital;


    private void OnMouseEnter()
    {
        _highlightHospital.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlightHospital.SetActive(false);
    }
}
