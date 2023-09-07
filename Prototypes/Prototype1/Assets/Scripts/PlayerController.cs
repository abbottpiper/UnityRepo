/*Piper Abbott-Phillips
 * PlayerController.cs
 * Assignment 2, Prototype 1
 * This script takes player keyboard input and moves the car vertically and horizontally at an adjustable speed
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed;
 
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //Move Forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
