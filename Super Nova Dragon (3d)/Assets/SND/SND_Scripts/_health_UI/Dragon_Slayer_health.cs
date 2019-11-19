using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon_Slayer_health : MonoBehaviour
{
    public static int DS_health = 200;
    public GameObject DS;
    public Slider DS_healthBar;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ReduceHealth", 1, 1);
    }
    void ReduceHealth()
    {
        //health = health -5;
        DS_healthBar.value = DS_health;
        if (DS_health <= 0)
        {
            //player.GetComponent<Animator>().SetTrigger("isDead");
            Debug.Log("The slayer is dead.");
        }
    }
   
}
