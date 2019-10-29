using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 10.0f;
    static Animator myAnim;


    // Start is called before the first frame update
    void Start()
    {

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


        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnim.SetInteger("state", 1);
        }

        if (Input.GetButtonDown("Jump"))
        {
            myAnim.SetInteger("state", 4);
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
