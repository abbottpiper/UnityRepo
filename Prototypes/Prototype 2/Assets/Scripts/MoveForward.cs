/*
       * Piper Abbott-Phillips
       * MoveForward.cs
       * Prototype 2, Assignment 3
       * Code allows for adjustment of object speed, and tells it to move forward at a constant rate
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
