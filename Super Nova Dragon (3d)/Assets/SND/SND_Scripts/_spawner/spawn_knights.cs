using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    private Vector3 spawnLocation;
    float timer = 15f;
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
            timer = 15;

        }        
    }
}
