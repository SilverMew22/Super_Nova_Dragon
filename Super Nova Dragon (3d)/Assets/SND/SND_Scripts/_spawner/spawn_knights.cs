using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;
    float timer = 20f;

    //public Transform parent;

    // Start is called before the first frame update
    void Start()
    {

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
            //run your  code
            timer = 20;

        }
        //timer += Time.deltaTime;
        //spawnLocation = parent.position;
        //change if to a time condition (night) and stop spawning once goal it met
        //if (Input.GetKeyDown(KeyCode.K))

        //{
        //if (timer >= 10f)
        //{
        //    Instantiate(clone, spawnLocation, Quaternion.identity);
        //}
        //if (timer >= 11f)
        //{
        //    Instantiate(clone, spawnLocation, Quaternion.identity);
        //}
        //if(timer >= 20f) { timer = 0f; }
        //}
    }
}
