using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Fire : MonoBehaviour
{
    public GameObject fire;
    public Animator animator;

    void Update()
    {
        if (!Input.GetKey(KeyCode.Space))
        {
            fire.SetActive(false);
            animator.enabled = false;
        }
        else { fire.SetActive(true);
            animator.enabled = true;
        }
    }

}

