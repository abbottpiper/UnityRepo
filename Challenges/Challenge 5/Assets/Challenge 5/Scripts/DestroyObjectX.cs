/*Piper Abbott-Phillips
 * DestroyObjectX.cs
 * Challenge 5
 * This script destroys the particle effect it's attached to after 2 seconds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
