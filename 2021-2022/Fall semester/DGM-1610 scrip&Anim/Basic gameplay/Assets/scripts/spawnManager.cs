using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float spawnRangex = 20;
    private float spawnPosZ = 20;
    private float startdelay = 2;
    private float spawnfreq = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    { //spawn animal with freq in flaot
        InvokeRepeating("SpawnRandomAnimal", startdelay, spawnfreq);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // random places animals spawn.
    void SpawnRandomAnimal()
    {
        int animalindex = Random.Range(0, animalprefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnPosZ);
            
        Instantiate(animalprefabs[animalindex],spawnPos, animalprefabs[animalindex].transform.rotation);
    }
}
