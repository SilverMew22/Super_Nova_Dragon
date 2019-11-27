﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilder : MonoBehaviour
{
    public GameObject SteveTheCube;

    void Start()
    {
        //BuildAWallAtZ(-2);
        //BuildAWallAtZ(2);
        //BuildWallAtX(-2);
        //BuildWallAtX(2);
        //BuildWallAtY(-2);
        //BuildWallAtY(2);

        BuildWallSuperFunction(-2, 2);
        BuildWallSuperFunction(2, 2);
        BuildWallSuperFunction(-2, 0);
        BuildWallSuperFunction(2, 0);
        BuildWallSuperFunction(-2, 1);
        BuildWallSuperFunction(2, 1);
    }

    void BuildAWallAtZ(float z)
    {
        for (int xPos = 0; xPos < 10; xPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(SteveTheCube, new Vector3(xPos * 2 - 10, yPos * 1.5f, z), Quaternion.identity);
            }
        }
    }

    void BuildWallAtX(float x)
    {
        for (int zPos = 0; zPos < 10; zPos++)
        {
            for (int yPos = 0; yPos < 5; yPos++)
            {
                Instantiate(SteveTheCube, new Vector3(x, yPos * 1.5f, zPos), Quaternion.identity);
            }
        }
    }

    ////void BuildWallAtY(float y)
    //{
    //    for (int zPos = 0; zPos < 10; zPos++)
    //    {
    //        for (int xPos = 0; xPos < 5; xPos++)
    //        {
    //            Instantiate(SteveTheCube, new Vector3(xPos, y, zPos), Quaternion.identity);
    //        }
    //    }
    //}

    void BuildWallSuperFunction(float theValueToPass, int zeroForXOneForYTwoForZ)
    {
        if (zeroForXOneForYTwoForZ == 0)
        {
            for (int zPos = 0; zPos < 10; zPos++)
            {
                for (int yPos = 0; yPos < 5; yPos++)
                {
                    Instantiate(SteveTheCube, new Vector3(theValueToPass, yPos * 1.5f, zPos), Quaternion.identity);
                }
            }
        }
        else if (zeroForXOneForYTwoForZ == 1)
        {
            for (int zPos = 0; zPos < 10; zPos++)
            {
                for (int xPos = 0; xPos < 5; xPos++)
                {
                    Instantiate(SteveTheCube, new Vector3(xPos, theValueToPass, zPos), Quaternion.identity);
                }
            }
        }
        else
        {
            for (int xPos = 0; xPos < 10; xPos++)
            {
                for (int yPos = 0; yPos < 5; yPos++)
                {
                    Instantiate(SteveTheCube, new Vector3(xPos * 2 - 10, yPos * 1.5f, theValueToPass), Quaternion.identity);
                }
            }
        }
    }
}