using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle_Health_System : MonoBehaviour
{
    public static int Cas_health = 500;
    public GameObject Cas;
    public Slider Cas_healthBar;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ReduceHealth", 1, 1);
    }
    void ReduceHealth()
    {
        //health = health -5;
        Cas_healthBar.value = Cas_health;
        if (Cas_health <= 0)
        {
            //player.GetComponent<Animator>().SetTrigger("isDead");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}