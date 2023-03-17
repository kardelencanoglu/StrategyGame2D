using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject powerPlant;
    [SerializeField] private GameObject soldierUnits;
    [SerializeField] private GameObject barracks;
    [SerializeField] private GameObject hospital;
    [SerializeField] private GameObject informationPanel;


    private static UIManager instance = null;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("UIManager").AddComponent<UIManager>();
            }
            return instance;
        }
    }
    private void OnEnable()
    {
        instance = this;
    }


    void Start()
    {
        informationPanel.SetActive(false);
        powerPlant.SetActive(false);
        soldierUnits.SetActive(false);
        barracks.SetActive(false);
        hospital.SetActive(false);

        //Initially all off
    }



    public void PowerPlantClick()
    {
        powerPlant.SetActive(true);
        informationPanel.SetActive(true);
        barracks.SetActive(false);
        soldierUnits.SetActive(false);
        hospital.SetActive(false);
    }

    public void BarracksClick()
    {
        barracks.SetActive(true);
        informationPanel.SetActive(true);
        powerPlant.SetActive(false);
        soldierUnits.SetActive(false);
        hospital.SetActive(false);
    }

    public void SoldierUnitsClick()
    {
        soldierUnits.SetActive(true);
        informationPanel.SetActive(true);
        powerPlant.SetActive(false);
        barracks.SetActive(false);
        hospital.SetActive(false);
    }

    public void HospitalClick()
    {
        hospital.SetActive(true);
        informationPanel.SetActive(true);
        powerPlant.SetActive(false);
        barracks.SetActive(false);
        soldierUnits.SetActive(false);
    }
}
