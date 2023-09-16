/*
       * Piper Abbott-Phillips
       * DetectCollisionsX.cs
       * Challenge 2, Assignment 3
       * Code trakcs whether a game object is destroyed with a collision box. If it is, it references the score tracker and adds 1 to the current score
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScoreX displayScoreXScript;
    

    private void Start()
    {
        displayScoreXScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScoreX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        displayScoreXScript.score++;
    }
}
