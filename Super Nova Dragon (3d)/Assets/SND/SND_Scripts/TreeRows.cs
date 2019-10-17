using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRows : MonoBehaviour
{
    public GameObject TreeRow;

    void Start()
    {
        BuildAWallAtZ(10);

        void BuildAWallAtZ(float z)//left and right wall
        {
            for (int xPos = 0; xPos < 20; xPos++)
            {
                for (int yPos = 0; yPos < 1; yPos++)
                {
                    Instantiate(TreeRow, new Vector3(xPos *2, yPos+1, z), Quaternion.identity);
                }
            }
        }


    }
}

