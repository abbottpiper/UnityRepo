/*Piper Abbott-Phillips
 * EnemyAI.cs
 * Assignment9 NavMesh
 * This script is a copy of the PlayerController script, but instead of targeting the mouse imput of the player, it targets the player character's location
 * The script also sets a chase distance float, in which the enemy ai will not run towards the player, as long as they're outside of the range
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyAI : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public GameObject player;
    public float chaseDistance;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
        character = GetComponent<ThirdPersonCharacter>();
        agent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
        chaseDistance = 8.0f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {

        float distanceFromTarget = Vector3.Distance(transform.position, player.transform.position);
        if (distanceFromTarget > agent.stoppingDistance && distanceFromTarget < chaseDistance)
        {
            agent.SetDestination(player.transform.position);
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            agent.SetDestination(transform.position);
            character.Move(Vector3.zero, false, false);
        }
    }
}
