/*
       * Piper Abbott-Phillips
       * DisplayScoreX.cs
       * Challenge 2, Assignment 3
       * Code controlls textbox which holds score. This script is referenced by the DetectCollisionsX script, which tells it when to add 1 score to the current score.
       * If player score >= 5, winText is shown, and players can reload scene with the R key
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreX : MonoBehaviour
{
    public Text textbox;
    public int score;
    public bool gameOver = false;
    public GameObject winText;
    
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
       
        textbox.text = "Score: " + score;
        if (score >= 5)
        {
            gameOver = true;
            winText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }

}
