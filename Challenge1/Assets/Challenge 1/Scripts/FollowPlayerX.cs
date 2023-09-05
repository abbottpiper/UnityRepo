
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //changed plane variable to player
    public GameObject player;
    //added new Vector3 to offset
    private Vector3 offset = new Vector3(30, 0, 10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //changed plane variable to player
        transform.position = player.transform.position + offset;
    }
}
