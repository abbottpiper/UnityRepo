/*Piper Abbott-Phillips
 * RotateCamera.cs
 * Assignment 7 Prototype 4
 * This script controls camera rotation on the horizontal axis, as well as how quickly the player can rotate it.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
   
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
