using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public GameObject Nova;
    int knightsKilled;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       

        }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova"))
        {
            //Debug.Log("The preditor hit you.");
            Destroy(gameObject);
            knightsKilled++;
        }
    }
}
