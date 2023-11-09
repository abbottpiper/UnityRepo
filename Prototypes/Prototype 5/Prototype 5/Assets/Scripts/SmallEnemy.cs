/*Piper Abbott-Phillips
 * SmallEnemy.cs
 * Assignment 6
 * This script inherits from the NormalEnemy script and allows for customizable moveSpeed and health values seperate from other enemy types
 */
using UnityEngine;

public class SmallEnemy : NormalEnemy
{
    void Start()
    {
        
        moveSpeed = 8f;
        health = 1;
    }

  
}




