using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManger : MonoBehaviour
{
    public GameObject obstaclePreFab;

    private Vector3 spaenPos = new Vector3(25, 0, 0);

    private float startDelay = 2;

    private float repeatRate = 2;

    private playerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePreFab, spaenPos, obstaclePreFab.transform.rotation);
        } 
    }
  
}
