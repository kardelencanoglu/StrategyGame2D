using CodeMonkey.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingPlacementPowerPlant : MonoBehaviour
{
    BuildingManager buildingManager;
    private SpriteRenderer _renderer;
    private Sprite buildSprite, cantBuildSprite;

    void Start()
    {
        buildingManager = GameObject.Find("BuildingManager").GetComponent<BuildingManager>();
        _renderer = GetComponent<SpriteRenderer>();
        buildSprite = Resources.Load<Sprite>("BuildPowerPlant");
        cantBuildSprite = Resources.Load<Sprite>("CantBuildPowerPlant");
        _renderer.sprite = buildSprite;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Build"))
        {
            buildingManager.canPlace = false;
        }
    }

    private void Update()
    {
        UpdateSprites();
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Build"))
        {
            buildingManager.canPlace = true;
        }
    }

    public void UpdateSprites()
    {
        if (buildingManager.canPlace)
        {
            _renderer.sprite = buildSprite;
        }
        else
        {
            _renderer.sprite = cantBuildSprite;
        }
    }

}