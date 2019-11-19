using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_mover : MonoBehaviour
{
    //Rigidbody myRb;
    //public float multiplier = 10f;
    //public float speed;

    static Animator myAnim;
    //AudioSource audioS;
    //public AudioClip moveSound;

    //Rigidbody myRb;
    public float multiplier = 10f;
    //int Prey_Eaten;
    //public int eatThresh = 3;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        //audioS = GetComponent<AudioSource>();

        //myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        //myAnim.SetInteger("state", 0);

        if (Input.GetKeyDown(KeyCode.W))
        {   
            myAnim.SetInteger("state", 1);
        }
        //if (Input.GetKeyDown(KeyCode.A))
        //{
          
        //    myAnim.SetInteger("state", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
           
        //    myAnim.SetInteger("state", 1);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
       
        //    myAnim.SetInteger("state", 1);
        //}
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Knight"))
        {        
            //Destroy(gameObject);
            }

            //if (Input.GetKey(KeyCode.W))
            //{
            //    transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
            //    myAnim.SetInteger("state", 1);

            //}
        }
    }


