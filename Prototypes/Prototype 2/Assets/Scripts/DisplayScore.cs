﻿/*
       * Piper Abbott-Phillips
       * DisplayScore.cs
       * Prototype 2, Assignment 3
       * Code controls the score display textbox. Pulls reference from the DetectCollisions to tell when to add 1 to player score.
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //set text component reference on start
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
