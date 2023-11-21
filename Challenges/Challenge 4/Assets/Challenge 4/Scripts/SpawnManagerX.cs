/*Piper Abbott-Phillips
 * SpawnManagerX.cs
 * Challenge 4
 * This script controls spawn location and logic for enemy balls. After every wave, it resets the players position. It tracks wave count, enemy scores and game over status as well
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float spawnRangeX = 10;
    private float spawnZMin = 15; // set min spawn Z
    private float spawnZMax = 25; // set max spawn Z
    public int enemyCount;
    public int waveCount = 1;
    public static bool gameOver = false;
    public static bool won = false;
    public Text textBox;
    public int enemyScore = 0;
    public GameObject player;
    

    // Update is called once per frame

    private void Start()
    {
         
    }
    void Update()
    {

        if (!gameOver)
        {
            textBox.text = "Wave: " + waveCount;
        }
        if (enemyScore >= waveCount && enemyScore > 0)
        {
            gameOver = true;
            won = false;
        }
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
       
        if (enemyCount == 0)
        {

            SpawnEnemyWave(waveCount + 1);
        }
        


        if (waveCount >= 11)
        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textBox.text = "You Win! \nPress R to Try Again";
            }
            else
            {
                textBox.text = "You Lose! \nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                gameOver = false;
                won = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }


    void SpawnEnemyWave(int enemiesToSpawn)
    {
        Vector3 powerupSpawnOffset = new Vector3(0, 0, -15);

        // If no powerups remain, spawn a powerup
        if (GameObject.FindGameObjectsWithTag("Powerup").Length == 0)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition() + powerupSpawnOffset, powerupPrefab.transform.rotation);
        }

        // Spawn number of enemy balls based on wave number
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

        waveCount++;
        ResetPlayerPosition();
    }


    void ResetPlayerPosition()
    {
        player.transform.position = new Vector3(0, 1, -7);
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        enemyScore = 0;
        
    }

}