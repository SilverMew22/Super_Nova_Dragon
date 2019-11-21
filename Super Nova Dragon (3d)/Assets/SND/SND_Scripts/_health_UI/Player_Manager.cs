using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Manager : MonoBehaviour
{
    public static float health = 100;
    public GameObject player;
    //public Slider healthBar;
    public Image healthBar;

    void Update()
    {
        healthBar.fillAmount = health / 100;
        if (health <= 0)
        {
            player.GetComponent<Animator>().SetTrigger("isDead");
        }
    }
}
    // Start is called before the first frame update
    //void Start()
    // {
    //   InvokeRepeating("ReduceHealth",1,1);
    // }
    //void ReduceHealth() {
    //health = health -5;
    //healthBar.value = health;
      
   // }
    // Update is called once per frame
    //void Update()
   // {
        
   // }
//}
