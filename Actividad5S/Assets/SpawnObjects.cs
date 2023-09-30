using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject coin;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    void SpawnCoins()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);


        Instantiate(coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }


    void Update()
    {
        if (Time.time > spawnTime)
        {
            SpawnCoins();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

}
