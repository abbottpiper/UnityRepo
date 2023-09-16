       /*
       * Piper Abbott-Phillips
       * PlayerControllerX.cs
       * Challenge 2, Assignment 3
       * Code sets variables for dog spawn time and dog cooldown time, Code also allows for dog prefab to be spawned from player location with spacebar. After spacebar is pressed to create a dogprefab in the game,
       * code checks for how long it has been since last dogprefab was spawned. If it has been less than 1.5 seconds, another prefab cannot be instantiated.
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawn = 0f;
    public float dogCD = 1.5f;
    
    private void Start()
    {
      

    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
           if (Time.time > dogCD + dogSpawn)
            {
                dogSpawn = Time.time;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
                        
        }



    }
}
