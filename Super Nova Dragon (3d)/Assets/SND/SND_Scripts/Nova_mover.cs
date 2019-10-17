using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nova_mover : MonoBehaviour
{
    //Rigidbody myRb;
    //public float multiplier = 10f;
    public float speed;

    Animator myAnim;
    AudioSource audioS;
    public AudioClip moveSound;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //myRb.AddForce(new Vector3(0f, 0f, 1f) * multiplier);
        myAnim.SetInteger("state", 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(1 * Time.deltaTime * speed, 0, 0);
            myAnim.SetInteger("state", 1);

        }
    }
}
