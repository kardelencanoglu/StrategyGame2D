using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSoldierUnits : MonoBehaviour
{
    [SerializeField] private GameObject _highlightSoldierUnits;


    private void OnMouseEnter()
    {
        _highlightSoldierUnits.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlightSoldierUnits.SetActive(false);
    }
}
