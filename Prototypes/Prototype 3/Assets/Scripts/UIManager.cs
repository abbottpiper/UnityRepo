﻿      /*
      * Piper Abbott-Phillips
      * UIManager.cs
      * Prototype 3, Assignment 4
      * Code tracks player score and win condition when colliding with game objects trigger points. Displays win/loss message and allows players to reload the scene with a button press
      */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public PlayerController playerControllerScript;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
      //Display score until game over
        if(!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        // Loss condition: Hit obstacle = end game
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again! ";
        }
        //win con = 10 points
        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;
            scoreText.text = "You Win!\nPress R to Try Again!";
        }
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

}
