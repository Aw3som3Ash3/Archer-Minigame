using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;

    public float spawnLocation = 9.5f;
    public int randomNumber;

    void Awake()
    {
        InvokeRepeating("SpawnTarget1", 1f, 0.5f);
        InvokeRepeating("SpawnTarget2", 1f, 1f);
        InvokeRepeating("SpawnTarget3", 1f, 2f);
    }

    private void Update()
    {
        GenerateRandomNumber();
    }

    void SpawnTarget1()
    {
        Instantiate(Target1, new Vector3((spawnLocation * randomNumber), Random.Range(-1.5f, 4.5f)), Quaternion.identity);
    }

    void SpawnTarget2()
    {
        Instantiate(Target2, new Vector2((spawnLocation * randomNumber), Random.Range(-1.5f, 4.5f)), Quaternion.identity);
    }

    void SpawnTarget3()
    {
        Instantiate(Target3, new Vector2((spawnLocation * randomNumber), Random.Range(-1.5f, 4.5f)), Quaternion.identity);
    }

    void GenerateRandomNumber()
    {
        randomNumber = Random.Range(-1, 2);

        if (randomNumber == 0)
        {
            GenerateRandomNumber();
        }
    }

    public void CancelSpawns()
    {
        CancelInvoke("SpawnTarget1");
        CancelInvoke("SpawnTarget2");
        CancelInvoke("SpawnTarget3");

    }
}
