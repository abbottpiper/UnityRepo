/*
* Piper Abbott-Phillips
* TriggerZoneAddScoreX.cs
* Challenge 3, Assignment 4
* Checks if player has collided with the money object trigger zone. If they have, adds 1 score to the UIManagers score system
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreX : MonoBehaviour
{
    private UIManagerX uIManagerX;
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManagerX = GameObject.FindObjectOfType<UIManagerX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManagerX.score++;
        }
    }

}
