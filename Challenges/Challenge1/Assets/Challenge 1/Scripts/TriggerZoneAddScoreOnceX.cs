/*
 *Piper Abbott-Phillips
 *TriggerZoneAddScoreOnceX.cs
 *Assignment 2, Challenge 1
 *This script checks to see if the player object enters the boxes trigger.
 *If they do, it changes the state of the trigger to true, and adds one point to the players score
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnceX : MonoBehaviour
{
    private bool triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManagerX.score++;
        }
    }
}
