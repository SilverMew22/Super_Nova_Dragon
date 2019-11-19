using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{

    Rigidbody knightRB;
    public Transform cas;
    public float forceAmt;
    public float distThrest;

    int knightsKilled;
    // Start is called before the first frame update
    void Start()
    {
        knightRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 preyDirection = Vector3.Normalize
        (cas.position - transform.position);


        if (Vector3.Distance(cas.position, transform.position) <= distThrest)
        { knightRB.AddForce(preyDirection * forceAmt); }


    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Nova"))
        {
            //Debug.Log("Nova hit you.");
            Destroy(gameObject);
            knightsKilled++;
            keepScore.Score += 001;
        }
    }
}
