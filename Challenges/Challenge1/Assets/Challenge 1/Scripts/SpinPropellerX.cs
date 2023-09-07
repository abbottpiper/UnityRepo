/*Piper Abbott-Phillips
 *SpinPropellerX.cs
 *Assignment 2, Challenge 1
 *This script tells the propeller object to spin forward at its Z-axis at a consistent and adjustable rate. 
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //I'm not 100% sure the Time.deltaTime is needed in this line, but it's working so I'm not gonna mess with it anymore
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
