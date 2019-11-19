using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon_slayer_damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova"))
        {
            Debug.Log("The slayer hit you.");
            Player_Manager.health -= 10;

        }

   
   
}}
