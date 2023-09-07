/*Piper Abbott-Phillips
 * CamFollowPlayer.cs
 * Assignment 2, Prototype 1
 * This script updates the main camera's position every frame to follow the player object at an offset
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
