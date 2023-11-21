/*Piper Abbott-Phillips
 * SpawnManager.cs
 * Assignment 7 Prototype 4
 * This script is responsible for the majority of game function. It spawns enemy and powerup prefabs in random positions within the ranges
 * It also tracks wave number and gameover bool, and controls scene reloading and ui display
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerupPrefab;
    public static bool gameOver = false;
    public static bool won = false;

    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        SpawnEnemyWave(waveNumber);
        SpawnPowerup(1);
    }

    private void SpawnPowerup(int powerupsToSpawn)
    {
        for (int i = 0; i < powerupsToSpawn; i++)
        {
           
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            //instantiate enemy in random pos
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (!gameOver)
        {
            textbox.text = "Wave: " + waveNumber;
        }
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerup(1);
        }
        if (waveNumber >= 11)
        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win! \nPress R to Try Again";                       
            }
            else
            {
                textbox.text = "You Lose! \nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            

            
        }
    }
}
