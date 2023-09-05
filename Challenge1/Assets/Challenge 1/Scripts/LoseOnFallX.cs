using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFallX : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80)
        {
            ScoreManagerX.gameOver = true;
       
        }
        if (transform.position.y < -51)
        {
            ScoreManagerX.gameOver = true;
          
        }
    }
}
