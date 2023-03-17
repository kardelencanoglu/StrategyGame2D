using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
    public GameObject SoldierSpawnPoint;
    private static SoldierSpawner instance = null;
    public Queue<GameObject> Soldiers = new Queue<GameObject>();
    GameObject isHereBarracks;

    
    public static SoldierSpawner Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("SoldierSpawner").AddComponent<SoldierSpawner>();
            }
            return instance;
        }
    }

    private void Update()
    {
        isHereBarracks = GameObject.Find("Barracks(Clone)");
    }


    private void OnEnable()
    {
        instance = this;
    }


    public void SoldierSpawn()
    {
        if(isHereBarracks != null)
        {
            var soldier = ObjectPooling.Instance.GetPoolObject(0);
            soldier.transform.position = SoldierSpawnPoint.transform.position;
            Soldiers.Enqueue(soldier);
        }
        //     StartCoroutine(DestroySoldier());

    }

    public void Soldier1Spawn() {
        if (isHereBarracks != null)
        {
            var soldier = ObjectPooling.Instance.GetPoolObject(1);
            soldier.transform.position = SoldierSpawnPoint.transform.position;
            Soldiers.Enqueue(soldier);
        }
        //    StartCoroutine(DestroySoldier());
    }

    public void Soldier2Spawn() {
        if (isHereBarracks != null)
        {
            var soldier = ObjectPooling.Instance.GetPoolObject(2);
            soldier.transform.position = SoldierSpawnPoint.transform.position;
            Soldiers.Enqueue(soldier);
        }
        //     StartCoroutine(DestroySoldier());
    }
    IEnumerator DestroySoldier()
    {
        yield return new WaitForSeconds(12f);
        var soldier = Soldiers.Dequeue();
        ObjectPooling.Instance.SetPoolObject(soldier, 0);
    }


}
