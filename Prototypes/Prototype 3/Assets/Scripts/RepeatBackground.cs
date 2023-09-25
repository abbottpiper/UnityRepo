using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //save starting position as a vector3
        startPosition = transform.position;

        // set repeatwidth to half of the width fo the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if background is farther to the left than the repeat width, reset to start pos
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
