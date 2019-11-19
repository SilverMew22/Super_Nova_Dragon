using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uni_Health_System_Down : MonoBehaviour
{
    public static int Uni_health = 100;
    public GameObject uni;
    public Slider Uni_healthBar;


    // Start is called before the first frame update
    void Start()
    {
        if (Uni_health <= 0) { 
        InvokeRepeating("ReduceHealth", 1, 1);
    }
    }
    void ReduceHealth()
    {
        Uni_health = Uni_health + 20;
        
        if (Uni_health >= 100)
        {
          Uni_healthBar.value = Uni_health;  
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
