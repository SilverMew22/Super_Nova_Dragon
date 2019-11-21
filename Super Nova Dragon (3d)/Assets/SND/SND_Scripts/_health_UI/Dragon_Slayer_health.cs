using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon_Slayer_health : MonoBehaviour
{
    public static float DS_health = 100;
    public GameObject DS;
    public Image healthBar;

    void Update()
    {
        healthBar.fillAmount = DS_health / 100;
        if (DS_health <= 0)
        {
            //player.GetComponent<Animator>().SetTrigger("isDead");
            Debug.Log("The slayer is dead.");
        }
    }
}



   
