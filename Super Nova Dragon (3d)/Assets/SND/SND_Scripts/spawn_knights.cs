﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;

    //public Transform parent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //spawnLocation = parent.position;
        //change if to a time condition (night) and stop spawning once goal it met
        if (Input.GetKeyDown(KeyCode.K))

        { Instantiate(clone, spawnLocation, Quaternion.identity); }
    }
}
