using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePowerPlant : MonoBehaviour
{
    [SerializeField] private GameObject _highlightPowerPlant;


    private void OnMouseEnter()
    {
        _highlightPowerPlant.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlightPowerPlant.SetActive(false);
    }
}
