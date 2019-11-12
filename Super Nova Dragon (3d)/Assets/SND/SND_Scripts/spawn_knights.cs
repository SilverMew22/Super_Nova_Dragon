using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //change if to a time condition (night) and stop spawning once goal it met
        if (Input.GetKeyDown(KeyCode.Y))

        { Instantiate(clone, spawnLocation, Quaternion.identity); }
    }
}
