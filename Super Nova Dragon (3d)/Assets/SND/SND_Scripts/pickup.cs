using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{ public Transform Nova;
  
   

    private void OnTriggerEnter(Collider col)
    {
        Player_Manager.health += 5;
        //Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
