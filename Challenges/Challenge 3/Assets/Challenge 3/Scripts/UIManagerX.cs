/*
* Piper Abbott-Phillips
* UIManagerX.cs
* Challenge 3, Assignment 4
* Tracks and displays player score as well as win/loss condition. If game ends, displays ending condition and allows player to reload the scene with a keypress
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UIManagerX : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public PlayerControllerX playerControllerScriptX;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScriptX == null)
        {
            playerControllerScriptX = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScriptX.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        if (playerControllerScriptX.gameOver && !won)
        {
            scoreText.text = "You Lose!\n Press R to Try Again ";
        }
        if (score >= 5)
        {
            playerControllerScriptX.gameOver = true;
            scoreText.text = "You Win!\n Press R to Play Again ";
            won = true;

        }
        if (playerControllerScriptX.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        
    }
}
