using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_hurt_Slayer : MonoBehaviour
{
    public GameObject DS;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova") && Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("The preditor hit you.");
            Dragon_Slayer_health.DS_health -= 5;
            DS.GetComponent<Animator>().SetTrigger("hurt");

        }
    }
}
