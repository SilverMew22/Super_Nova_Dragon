using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Fire : MonoBehaviour
{
    private bool isGettingBigger = false;


    void Update()
    {

       
    }

    public void MakeMyBool(bool nextValue)
    {
        isGettingBigger = nextValue;
    }

    void OnCollisionEnter(Collision col)
    {
        if ( Input.GetButton("Jump"))
        {
            //Debug.Log("The preditor hit you.");
            isGettingBigger=true;
            Dragon_Slayer_health.DS_health -= 20;
            transform.localScale = new Vector3(1, 1, 1) * (transform.localScale.z + .1f);
        }
        else { transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, .1f); }
    }
}