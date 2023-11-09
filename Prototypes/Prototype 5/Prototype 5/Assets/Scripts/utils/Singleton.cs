/*Piper Abbott-Phillips
 * Singleton.cs
 * Assignment 6
 * This script creates a Singleton that maintains a single instance accessible through a static property while preventing duplicate instances, allowing easy global access to the Singleton throughout the game.
 */
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T instance;
        public static T Instance
        {
            get { return instance; }
        }

        public static bool IsInitialized
        {
            get { return instance != null;  }
        }

        private void Awake()
        {
            if (instance != null)
            {
                Debug.LogError("[Singleton] instantiating a second instance of a singleton class");

            }
            else
            {
                instance = (T)this;
            }
        }

        protected virtual void OnDestroy()
        {
            //if destroyed, make null so another instance can be created
            if (instance == this)
            {
                instance = null;
            }
        }
    }
}