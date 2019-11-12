using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class unicorn_heal : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Uni"))
        {
            //collectSound.Play();
            keepScore.Score += 100;
            //Destroy(gameObject);
        }
    }
}