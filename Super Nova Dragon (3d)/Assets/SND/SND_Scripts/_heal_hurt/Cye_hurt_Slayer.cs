using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cye_hurt_Slayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova") && Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("The preditor hit you.");
            Dragon_Slayer_health.DS_health -= 5;

        }
    }
}
