/*Piper Abbott-Phillips
 * EnemyAI.cs
 * Assignment 7 Prototype 4
 * This script sets the enemy speed, and causes them to move towards the players transform position continously. 
 * It uses .normalized to ensure their speed is consistent, not matter the distance to the player.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   private Rigidbody enemyRb;
   public GameObject player;
   public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //add force toward the direct from the player to the enemy

        //vector for direction from enemy to player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //add force toward player
        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
    
        
    
}
