/*Piper Abbott-Phillips
 * Prefab Spawner
 * Assignment 6
 * This script spawns a random prefab from an array at a random psotion between a set x and z range.  
 */
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabsToSpawn; 
    public int totalSpawnCount = 10; 
    public float spawnInterval = 3f; 

    private int currentSpawnCount = 0;

    void SpawnRandomPrefab()
    {
        if (currentSpawnCount < totalSpawnCount)
        {
            
            float xPositiveLimit = 50f; 
            float xNegativeLimit = -21f; 
            float zPositiveLimit = 74f; 
            float zNegativeLimit = -7f; 

            Vector3 randomPosition = new Vector3(Random.Range(xNegativeLimit, xPositiveLimit), 0.5f, Random.Range(zNegativeLimit, zPositiveLimit));

            GameObject randomPrefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];

            Instantiate(randomPrefab, randomPosition, Quaternion.identity);

            currentSpawnCount++;

            Invoke("SpawnRandomPrefab", spawnInterval);
        }
    }

    void Start()
    {
        SpawnRandomPrefab();
    }
}
