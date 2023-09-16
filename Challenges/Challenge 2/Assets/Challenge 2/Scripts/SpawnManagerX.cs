         /*
		 * Piper Abbott-Phillips
		 * SpawnManagerX.cs 
		 * Challenge 2, Assignment 3
		 * Code tells game to spawn a random ball prefab out of the set array. It also randomly selects a loctaion between the left and right limit of the screen, as well as sets the dealy for spawning.
		 * Finally, using a Coroutine, a random float between 3 and 5 seconds is chosen to vary and delay ball spawns
		 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
   //rivate float spawnInterval = 4.0f;
    public HealthSystemX healthSystemx;

    // Start is called before the first frame update
    void Start()
    {
        healthSystemx = GameObject.FindGameObjectWithTag("HealthSystemX").GetComponent<HealthSystemX>();
        StartCoroutine(SpawnRandomPrefabWithCoroutineX());
        
//nvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    IEnumerator SpawnRandomPrefabWithCoroutineX()
    {
        yield return new WaitForSeconds(3f);
        while (!healthSystemx.gameOver)
        {
            SpawnRandomBall();
            float randomDelay = Random.Range(3.0f, 5.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int prefabIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
