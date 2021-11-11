using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objects;
    

    private float zObjectSpawn = 10.0f;

    private float xObjectSpawn = 10.0f;

    private float objectSpawnTime = 2.0f;
    private float startDelay = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, objectSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObject()
    {
        float randomX = Random.Range(-xObjectSpawn, xObjectSpawn);
        int randomIndex = Random.Range(0, objects.Length);

        Vector3 spawnPos = new Vector3(randomX, 1, zObjectSpawn);

        Instantiate(objects[randomIndex], spawnPos, objects[randomIndex].gameObject.transform.rotation);
    }
}
