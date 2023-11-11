/*Piper Abbott-Phillips
 * NormalEnemy.cs
 * Assignment 6
 * This script sets the parameters for the NormalEnemy type, as well as sets up inheretence for the other enemy types. 
 * It also causes the enemy capsules to chase the player, and allows objects to be destroyed when their health hits 0
 */
using UnityEngine;

public class NormalEnemy : MonoBehaviour, IDamageable
{
    public float moveSpeed;
    public int health;

    protected Transform player;

    protected virtual void Update()
    {
        ChasePlayer();
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }
    protected void ChasePlayer()
    {
        if (player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }

        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            transform.LookAt(player);
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
    //decided not to use, too scared to remove
    public virtual void Attack()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Enemy took " + damageAmount + " damage. Health: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        
        Destroy(gameObject);
    }
}
