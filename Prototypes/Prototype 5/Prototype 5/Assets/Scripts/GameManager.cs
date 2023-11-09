/*Piper Abbott-Phillips
 * GameManager.cs
 * Assignment 6
 * This is a partially utilized gamemanager that uses allows the player to pause, and unpause the game, as well as load and unload scenes.
 */
using Assets.Scripts;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager: Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;
    //variable to track current level
    private string CurrentLevelName = string.Empty;

    
/*    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //make sure this game manager persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second" +
                "instance of singleton Game Manager");
        }
    }*/
    //methods to load/unload scenes
    public  void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameMAnager] Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }
    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameMAnager] Unable to unload level " + levelName);
            return;
        }
     
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameMAnager] Unable to unload level " + CurrentLevelName);
            return;
        }
    }
    // pausing and unpausing
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
}
