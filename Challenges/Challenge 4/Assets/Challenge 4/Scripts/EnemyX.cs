/*Piper Abbott-Phillips
 * EnemyX.cs
 * Challenge 4
 * This script causes enemies to move towards the player goal when they spawn. It also increments their speed every wave and destroys them when they interact with a goal.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float baseSpeed = 5;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private SpawnManagerX spawnManager;
    

    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.FindGameObjectWithTag("PlayerGoal");
        spawnManager = GameObject.FindObjectOfType<SpawnManagerX>();

    }

    // Update is called once per frame
    private void Update()
    {
        if (spawnManager != null)
        {

            Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * (baseSpeed + (spawnManager.waveCount * 50)) * Time.deltaTime);
        }


    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Player Goal")
        {
            _ = spawnManager.enemyScore++;
            Debug.Log("Scored");
            Destroy(gameObject);
            
        }
    }

}