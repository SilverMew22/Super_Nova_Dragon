using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool disabled = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (disabled)
            {
                objectToDisable.SetActive(false);
            }
            
        //objectToDisable.SetActive(true);


        if (Input.GetKey(KeyCode.Q) && disabled == false)
            {
                {
                    objectToDisable.SetActive(true);
                }

            }

        }
    }
}
    


