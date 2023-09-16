/*
       * Piper Abbott-Phillips
       * DestroyOutOfBounds.cs
       * Prototype 2, Assignment 3
       * Code checks whether a game object leaves the play field, both from the top and bottom. If it does, the object is destroyed. If it leaves from the bottom boundary, HealthSystem is refrerenced to take 1 damage
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 23;
    public float bottomBound = -12;

    private HealthSystem healthSystemScript;
    // Start is called before the first frame update
    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            //grab health systesm script and call TakeDamage()
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}
