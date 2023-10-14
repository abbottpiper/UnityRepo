/*Piper Abbott-Phillips
 * PlayerEnterTrigger.cs
 * Assignmnet 4A
 * I am 99% sure this script isn't attached to any game objects and is a leftover from when I was troubleshooting, but I'm too scared to remove it. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D theCollider)
    {
        //As I'm writing my header comments now, I see why this script didn't work. I had the CompareTag the script was looking for set to the trigger itself instead of the player
        if (theCollider.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
