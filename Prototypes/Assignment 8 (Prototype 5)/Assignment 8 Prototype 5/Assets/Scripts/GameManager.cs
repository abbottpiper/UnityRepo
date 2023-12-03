/*Piper Abbott-Phillips
 * GameManager.cs
 * Assignmnet 8 Prototype 5
 * This script controls most game functionality. It spawns objects from the Listand controls spawn rate while isGameActive is true, controls the score text display, and allows players to reload on game over
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool isGameActive;
    public GameObject titleScreen;

  
    public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
 
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            //wait 1 sec
            yield return new WaitForSeconds(spawnRate);
            //pick a random index betwee 0 and number of prefabs
            int index = Random.Range(0, targets.Count);
            //spawn the prefab at the randomly selected index
            Instantiate(targets[index]);

          
        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
