/*Piper Abbott-Phillips
 * TutorialManager.cs
 * Assignment 7 Prototype 4
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Spacebar
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {
       
        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Pass Wave 10 to Win \nIf you fall off the platform, you lose \nPress (Spacebar) to continue.";
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            tutorialPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
