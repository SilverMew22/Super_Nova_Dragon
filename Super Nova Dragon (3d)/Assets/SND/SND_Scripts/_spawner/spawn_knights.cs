﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    private Vector3 spawnLocation;
    float timer = 5f;
    public Quaternion rotation;
    //public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = transform.position + Vector3.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Instantiate(clone, spawnLocation, Quaternion.identity);
            timer = 5;

        }
       // if (Player_Manager.health <= 0f || Castle_Health_System.Cas_health <= 0f)
       // { clone.SetActive(false); }
    }
}
