using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Manager : MonoBehaviour
{
    public static float health = 100;
    public GameObject player;
    public GameObject player_ani;
    public Image healthBar;
    public Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        //if (health <= 0) {Restart(); }
    }

    void Update()
    {
        healthBar.fillAmount = health / 100;
        if (health <= 0)
        {
            player.GetComponent<Animator>().SetTrigger("isDead");
            player_ani.SetActive(false);

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.LoadLevel(scene.name);
        }

        

        
    }
    void Restart() {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Application.LoadLevel(scene.name);
        }
    }
        
    } 

   
