/*Piper Abbott-Phillips
 * WinTrigger.cs
 * Assignmnet 4A
 * This script checks to see if the player has entered the win trigger at the end of the game.
 * If they have, it sets the trigger to "true", which then interacts with the score manager
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinTrigger : MonoBehaviour
{
    public static bool winTrig = false;
    
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            winTrig = true;
        }
    }
}
