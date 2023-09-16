       /*
       * Piper Abbott-Phillips
       * DestroyOutOfBoundsX.cs
       * Challenge 2, Assignment 3
       * Code sets private float for the left most limit of the play area and the bottom most limit of the play area. If an object's position crosses either the y threshold or the x threshold, the object is deleted.
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;
    private HealthSystemX healthSystemXScript;

   void Start()
    {
        healthSystemXScript = GameObject.FindGameObjectWithTag("HealthSystemX").GetComponent<HealthSystemX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            healthSystemXScript.TakeDamage();
        }

    }
}
