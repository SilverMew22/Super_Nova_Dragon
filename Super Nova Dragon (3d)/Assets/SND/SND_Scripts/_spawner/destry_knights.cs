using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destry_knights : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("cleanUp"))
        {
            Debug.Log("erase knight");
            Destroy(gameObject);
           

        }
    }
}
