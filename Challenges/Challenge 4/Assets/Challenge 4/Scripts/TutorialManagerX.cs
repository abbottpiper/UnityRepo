/*Piper Abbott-Phillips
 * TutorialManagerX.cs
 * Challenge 4
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Tab
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManagerX : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {

        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Pass Wave 10 to Win!\nIf all enemy balls enter your goal, you lose!\nPress SPACE to boost\nPress TAB to continue";
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {

            tutorialPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
