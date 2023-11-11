/*Piper Abbott-Phillips
 * Inventory.cs
 * Assignment 6
 * This script was created during the follow along video and has no actual functionality. In theory, it allows for an organized list of item ids to be added to a game object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryItem item;
        public List<InventoryItem> inventory;
        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();
            inventory = new List<InventoryItem>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}