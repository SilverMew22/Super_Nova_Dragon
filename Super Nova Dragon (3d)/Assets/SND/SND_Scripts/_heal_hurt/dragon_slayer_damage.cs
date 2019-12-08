using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon_slayer_damage : MonoBehaviour
{
    public GameObject DS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova")&& !Input.GetKey(KeyCode.Space))
        {
            Debug.Log("The slayer hit you.");
            Player_Manager.health -= 10;
            DS.GetComponent<Animator>().SetTrigger("attack");
        }

   
   
}}
