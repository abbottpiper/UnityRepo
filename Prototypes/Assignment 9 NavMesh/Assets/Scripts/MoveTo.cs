/*Piper Abbott-Phillips
 * MoveTo.cs
 * Assignment9 NavMesh
 * This script moves the navmesh agent position to the position of the goal. It is disabled and not used throughout the project file.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour
{
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
