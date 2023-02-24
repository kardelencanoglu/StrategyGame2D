using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSoldier : MonoBehaviour
{
    [SerializeField] GameObject _exitPoint;

    public Queue<GameObject> Soldier = new Queue<GameObject>();
    public GameObject _spawnPoint;
   // SpawnedChickensManager spawnedChickensManager;
    public bool isSoldierSpawned = false;

    private static SpawnSoldier instance = null;
    public static SpawnSoldier Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("SoldierSpawner").AddComponent<SpawnSoldier>();
            }
            return instance;
        }
    }
    public float soldierSpawnTime;
    public float soldierSpawnRate;
    private void OnEnable()
    {
        instance = this;
    }

    private void Start()
    {
        InvokeRepeating("SpawnSoldier", soldierSpawnTime, soldierSpawnRate);
    }

    private void SoldierSpawn()
    {
        var soldier = ObjectPooling.Instance.GetPoolObject(0);
        Soldier.Enqueue(soldier);
        soldier.transform.position = new Vector3(_spawnPoint.transform.position.x, _spawnPoint.transform.position.y, _spawnPoint.transform.position.z);
        isSoldierSpawned = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ExitPoint"))
        {
            var soldier = Soldier.Dequeue();
            ObjectPooling.Instance.SetPoolObject(soldier, 0);
            isSoldierSpawned = false;
        }
    }
}