using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeSpawner : MonoBehaviour
{
    [SerializeField] private Metal metal = new Metal();
    [SerializeField] private float spawnTime;
    [SerializeField] private float spawnTimer;
    
    void Start()
    {
        spawnTimer = 0.0f;
    }
    
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnTime)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int randX = Rand();
        int randZ = Rand();
        Vector3 position = new Vector3(randX, 0.5f, randZ);

        Instantiate(metal, position, Quaternion.identity);

        spawnTimer = 0.0f;
        spawnTime = Random.Range(15f, 45f);
    }

    int Rand()
    {
        int coords = Random.Range(-20, 20);
        return coords;
    }
}
