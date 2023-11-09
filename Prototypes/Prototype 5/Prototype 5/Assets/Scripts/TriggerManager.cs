/*Piper Abbott-Phillips
 * TriggerManager.cs
 * Prototype 5/Assignment 6
 * This script checks whether the win trigger has been entered, and if it has, it displays the You Win text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerManager : MonoBehaviour
{
    public static bool winTrig = false;
    public static bool gameOver;
    public TriggerManager winTrigger;
    public static bool won = false;
    public Text textbox;
    void Start()
    {
        gameOver = false;
        won = false;

    }

    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            winTrig = true;
        }
    }
   void Update()
    {
        if (TriggerManager.winTrig == true)
        {
            gameOver = true;
            won = true;
            textbox.text = "You Win!"; 
        }
      
    }
}