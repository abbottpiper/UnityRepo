/*Piper Abbott-Phillips
 * TriggerZoneAddScoreOnce.cs
 * Assignment 2, Prototype 1
 * This script checks whether the trigger zones have been colided wtih. If they have, it sets their state to "triggered" so they cannot be passed through again, and adds one point to the players score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
