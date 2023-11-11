/*Piper Abbott-Phillips
 * LargeEnemy.cs
 * Assignment 6
 * This script inherits from the NormalEnemy script and allows for customizable moveSpeed and health values seperate from other enemy types
 */
using UnityEngine;

public class LargeEnemy : NormalEnemy
{
    void Start()
    {
        
        moveSpeed = 4f;
        health = 50;
    }

    
}
