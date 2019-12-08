using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire_duration : MonoBehaviour
{
    public static float fire_health = 100;
    public GameObject fire;
    public Image healthBar;

    void Update()
    {
        healthBar.fillAmount = fire_health / 100;
        if (fire_health <= 0)
        {
            
            Debug.Log("Fire went down");
        }
    }
}




