using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uni_Health_System : MonoBehaviour
{
    public static int U_health = 100;
    public GameObject Uni;
    public Slider U_healthBar;
    public GameObject clone;
    public Vector3 spawnLocation_cas;
    public Vector3 spawnLocation_ground;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ReduceHealth", 1, 1);
        
    }
    void GainedHealth()
    {
        U_health = U_health +20;
        U_healthBar.value = U_health;
    }

        void ReduceHealth()
    {
        //health = health -5;
        U_healthBar.value = U_health;
        if (U_health <= 0)
        {
            Destroy(gameObject);
            U_health_Drained();

        }
    }
    void U_health_Drained() {
        InvokeRepeating("GainedHealth", 1, 1); 
        Instantiate(clone, spawnLocation_cas, Quaternion.identity); 
       
        if (U_health == 100) {
            U_healthBar.value = U_health;
            Destroy(gameObject);
            Instantiate(clone, spawnLocation_ground, Quaternion.identity);

        }
        
    }
    
}