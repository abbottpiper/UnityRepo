      /*
       * Piper Abbott-Phillips
       * ShootPrefab.cs
       * Prototype 2, Assignment 3
       * Code checks for space key press, and on button down, shoots a prefab at the players current location
       */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
