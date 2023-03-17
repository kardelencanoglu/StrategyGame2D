using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] private GameObject _highlightBarracks;


    private void OnMouseEnter()
    {
        _highlightBarracks.SetActive(true);
    }

    private void OnMouseExit()
    {
        _highlightBarracks.SetActive(false);
    }
}
