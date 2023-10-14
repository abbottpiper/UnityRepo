/*Piper Abbott-Phillips
 * ScoreManager.cs
 * Assignmnet 4A
 * This script checks managers the scoretext ui element and manages gameover states and scene reloading
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
    public WinTrigger winTrigger;
    

    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (!gameOver)
            {
                textbox.text = "Score: " + score;
            }

        if (true)
        {

        }
        if (WinTrigger.winTrig == true && score >= 10)
        {
            gameOver = true;
            won = true;
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
