/*Piper Abbott-Phillips
 * PlayerEnterTrigger.cs
 * Assignment 2, Prototype 1
 * This script checks if a trigger has been colided with. If it has, one point is added to the player's score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}