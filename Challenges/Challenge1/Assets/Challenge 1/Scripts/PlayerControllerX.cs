/*Piper Abbott-Phillips
 *PlayerControllerX.cs
 *Assignment 2, Challenge 1
 *This script is responsible for taking player keyboard input, and controlling the player object's speed and direction.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    //added public float for horizontal input
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        //added horizontal input call
        horizontalInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate - added horizontalInput call to this line
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);

        // tilt the plane up/down based on up/down arrow keys - added verticalInput call to this line
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
      
    }
}
