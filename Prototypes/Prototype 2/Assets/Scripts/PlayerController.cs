﻿/*
       * Piper Abbott-Phillips
       * PlayerController.cs
       * Prototype 2, Assignment 3
       * Code allows player to move horizontally across the screen. Code also holds player character in game boundary
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    
    void Update()
    {
        //get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //transform horizontally with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keep player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
