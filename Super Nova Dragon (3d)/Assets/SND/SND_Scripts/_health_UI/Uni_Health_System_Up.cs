using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uni_Health_System_Up : MonoBehaviour
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
        U_healthBar.value = U_health;
        if (U_health >= 100)
        {
            U_healthBar.value = U_health;
        }        
        }

        void ReduceHealth()
        {      
        U_healthBar.value = U_health;
        if (U_health <= 0)
        {
            Destroy(gameObject);
            U_health_Drained();
        }
        }

        void U_health_Drained() { 
        Instantiate(clone, spawnLocation_cas, Quaternion.identity);
   
        if (U_health >= 100) {
            U_healthBar.value = U_health;
            Destroy(gameObject);
            Instantiate(clone, spawnLocation_ground, Quaternion.identity);

        }                      
        }        
    
}
