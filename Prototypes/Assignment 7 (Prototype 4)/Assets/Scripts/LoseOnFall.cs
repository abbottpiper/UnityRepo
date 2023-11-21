/*Piper Abbott-Phillips
 * LoseOnFall.cs
 * Assignment 7 Prototype 4
 * This script tracks if the players y position drops below -7.5. If it does, it references the SpawnManager and tells the game to end.
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
        if (transform.position.y < -7.5)
        {
            SpawnManager.gameOver = true;

        }
    }
}