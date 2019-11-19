using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform Nova;



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Nova"))
        {
            Player_Manager.health += 5;
            Uni_Health_System.U_health -= 10;
            Debug.Log("Uni healed Nova.");
        }
        if (col.gameObject.CompareTag("Castle"))
        {
            Debug.Log("Unicorn is on the castle.");
            Uni_Health_System.U_health ++;
            InvokeRepeating("GainHealth", 1, 1);
        }

    }

    void GainHealth()
    {
    Uni_Health_System.U_health ++;}

   void Update()
    {
        if (gameObject.CompareTag("Castle"))
        {
            Debug.Log("Unicorn is on the castle.");
            
            InvokeRepeating("GainHealth", 1, 1);
        }
    }
}
    

       

