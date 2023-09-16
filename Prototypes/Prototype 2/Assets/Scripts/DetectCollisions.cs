/*
       * Piper Abbott-Phillips
       *DetectCollisions.cs
       * Prototype 2, Assignment 3
       * Code checks to see if an object with a colider was destroyed. If so, it references the score tracker to add one point to the players score
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
   private DisplayScore displayScoreScript;
    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
