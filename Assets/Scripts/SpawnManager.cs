using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float startDelay = 1.0f;
  
    public GameObject[]  obstaclePrefab;
    private Vector3 spawnPos = new Vector3(26, 0, 0);
    private PlayerControl playerControlScript;

    void Start()
    {
           float  spawnInterval = Random.Range(1.7f, 5.0f);
    InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        

        if (playerControlScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
        }
    }
}
