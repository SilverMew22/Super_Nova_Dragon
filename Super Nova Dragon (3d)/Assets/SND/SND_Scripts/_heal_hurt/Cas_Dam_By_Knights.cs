﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cas_Dam_By_Knights : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Knight"))
        {
            //Debug.Log("The preditor hit you.");
            Castle_Health_System.Cas_health -= 5;

        }
    }
}
