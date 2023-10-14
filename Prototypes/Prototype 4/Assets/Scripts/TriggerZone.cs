/*Piper Abbott-Phillips
 * TriggerZone.cs
 * Assignmnet 4A
 * This script checks to see if the player has entered the collectable gems trigger zone. If they have, it adds 1 score to the total
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private bool triggered = false;
    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
