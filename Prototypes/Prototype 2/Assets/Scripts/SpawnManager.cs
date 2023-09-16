       /*
       * Piper Abbott-Phillips
       * SpawnManager.cs
       * Prototype 2, Assignment 3
       * Code spawns random animal prefab from the array and randomly places them between the screen boundaries. Using a coroutine, the game creates a random spawn delay between 1.3 and 3 seconds
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    //variables for spawn position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 23;
    public HealthSystem healthSystem;
    void Start()
    {
        //get reference to health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f); 
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }
   
    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //add 3 sec delay b4 first spawning objs
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();
            float randomDelay = Random.Range(1.3f, 3.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }
    void SpawnRandomPrefab()
    {
        //pick random animal index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate a random spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);
        //spawn animal
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
