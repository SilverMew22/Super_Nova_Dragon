using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FA_Knights : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;
    

    public Rigidbody fireRB;
    public Transform knight;
    public float forceAmt;
    public float distThrest;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation =transform.position;
        fireRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { Instantiate(clone, spawnLocation, Quaternion.identity); }

        Vector3 preyDirection = Vector3.Normalize
        (knight.position - transform.position);


        if (Vector3.Distance(knight.position, transform.position) <= distThrest)
        { fireRB.AddForce(preyDirection * forceAmt); }
    }


}
