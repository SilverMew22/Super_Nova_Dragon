using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState{spawning, waiting,counting };
    [System.Serializable]

    public class Wave
    { 
    public string name;
    public Transform enemy;
    public int count;
    public float rate;
    }
public Wave[] waves;
    private int nextWave = 0;
    public float waveCountDown;
    public float timeBetweenWaves = 5f;
    private SpawnState state = SpawnState.counting;
     void Start()
    {
        waveCountDown = timeBetweenWaves;
    }
     void Update()
    {
        if (waveCountDown <= 0) { }
    }
}

