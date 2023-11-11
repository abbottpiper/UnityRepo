/*Piper Abbott-Phillips
 * Chase.cs
 * Assignment 6
 * This is my original version of the player chasing script that isn't being used. It continously moves an object its attached to towards the players location.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Chase : MonoBehaviour
    {
        public Transform player; 
        public float moveSpeed = 5f; 

        private Rigidbody enemyRigidbody;

        void Start()
        {
           
            enemyRigidbody = GetComponent<Rigidbody>();

            
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void Update()
        {
            if (player == null)
            {
                
                return;
            }

            
            Vector3 direction = player.position - transform.position;

           
            direction.Normalize();

           
            enemyRigidbody.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);

            
            transform.LookAt(player);
        }
    }
