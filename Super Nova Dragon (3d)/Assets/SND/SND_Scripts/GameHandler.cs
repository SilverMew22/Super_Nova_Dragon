using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
		healthsystem healthsystem = new healthsystem(100);
        Debug.Log("Health: " +healthsystem.GetHealth());
    }

    
}
