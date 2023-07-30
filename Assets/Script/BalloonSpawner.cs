using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloonPrefabs;

    public float SpawnTime = 0f;
    float spawnTimeLeft = 0f;

   void Update()
    {
        if(spawnTimeLeft >= SpawnTime)
        {
            int randBalloon = Random.Range(0, balloonPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            Instantiate(balloonPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            spawnTimeLeft = 0f;
        }
        else
        {
            spawnTimeLeft = spawnTimeLeft + Time.deltaTime;
        }
        
    }

    public void AdjustSpawnTime (float newSpawnTime)
    {
        SpawnTime = newSpawnTime;
    }
}
