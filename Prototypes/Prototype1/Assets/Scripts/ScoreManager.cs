/*Piper Abbott-Phillips
 * ScoreManager.cs
 * Assignment 2, Prototype 1
 * This script keeps track of the current gamestate, as well as the players score. 
 * If the game ends or the players score reaches the win condition, it ends the game and outputs text depending on whether they've won or lost
 * It also allows the player to restart the game on a game over
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win! \nPress R to Try Again";

            }
            else
            {
                textbox.text = "You Lose!\nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
