/*Piper Abbott-Phillips
 * LoseOnFall.cs
 * Assignment 2, Prototype 1
 * This script checks to see if the player object's y position is below the play area. If it is, it ends the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;

        }
    }
}
