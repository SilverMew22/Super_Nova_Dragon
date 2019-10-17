﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_Jump : MonoBehaviour
{
    public bool onGround;
    private Rigidbody rb;
    Rigidbody myRb;

   
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();

        
    }


    void Update()
    {

        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 5f, 0f);
                onGround = false;
               
            }
        }

       



    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag
      ("Ground")) { onGround = true; }
    }
}
