/*Piper Abbott-Phillips
 * IDamageable.cs
 * Assignment 6
 * This script defines an interface and requires implementing classes to have methods for taking damage and pulling hte associated GameObject  
 */
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damageAmount);
    GameObject GetGameObject();
}
