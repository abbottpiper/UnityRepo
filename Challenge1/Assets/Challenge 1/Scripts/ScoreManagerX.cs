/*
 *
 *
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added UnityEngui.UI and UnitEngine.SceneManagement
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagerX : MonoBehaviour
{
    //added game management statics and textbox reference
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;
    public Text textbox;
    
    // Start is called before the first frame update
    void Start()
    {
        //added gamestate info at start/restart
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //call to check if gameOver = false
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        //call to check if player score is at or above required victory level
            if (score >= 5)
        {
            won = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "WINNER! \nPress R to Restart Game";
            }
            else
            {
                textbox.text = "You Killed An Innocent Pilot.\nPress R to Try More Carefully";
            }
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }
           
        
    }
}
