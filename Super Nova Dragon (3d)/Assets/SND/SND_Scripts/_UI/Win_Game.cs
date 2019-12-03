using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Game : MonoBehaviour
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
        if (keepScore.Score >= 100)
        {
            if (disabled)
            {
                objectToDisable.SetActive(false);
            }
            else
                objectToDisable.SetActive(true);
        }
       

        }
    }

