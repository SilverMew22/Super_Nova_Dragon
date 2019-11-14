using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 10.0f;
    static Animator myAnim;
    public bool onGround;
    private Rigidbody rb;
    Rigidbody myRb;

    // Start is called before the first frame update
    void Start()
    {//to jump
        onGround = true;
        rb = GetComponent<Rigidbody>();
        //to move and play animation
        myAnim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate(straffe, 0, translation);
        myAnim.SetInteger("state", 0);

        if (Input.GetKey(KeyCode.W))
            {
            myAnim.SetInteger("state", 1);           
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetInteger("state", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myAnim.SetInteger("state", 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetInteger("state", 1);
        }

        if (onGround)
        {
            if (Input.GetButton("Jump"))
            {
                rb.velocity = new Vector3(0f, 6f, 0f);
                onGround = false;

                myAnim.SetInteger("state", 4);
            }
        }


        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
