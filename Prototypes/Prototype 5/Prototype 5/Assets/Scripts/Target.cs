/*Piper Abbott-Phillips
 * Target.cs
 * Prototype 5
 * This script assigns a health value to any object it's attached to. If it is hit by a raycast, the objects health is reduced until it's destroyed. 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <=0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
