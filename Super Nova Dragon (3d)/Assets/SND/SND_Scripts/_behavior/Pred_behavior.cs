using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pred_behavior : MonoBehaviour
{
    //Rigidbody predRB;
    public Transform prey;
    //public float forceAmt;
    //public float distThrest;

    Vector3 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        //predRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(prey.position.x, transform.position.y, prey.position.z);
        //Vector3 preyDirection = Vector3.Normalize
        //(prey.position - transform.position);


        //if (Vector3.Distance(prey.position, transform.position) <= distThrest)
        //{ predRB.AddForce(preyDirection * forceAmt); }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, 2 * Time.deltaTime);
    }
}
