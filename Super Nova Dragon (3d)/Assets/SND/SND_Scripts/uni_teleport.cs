using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uni_teleport : MonoBehaviour
{
	public GameObject clone;
	public Vector3 spawnLocation_cas;
	public Vector3 spawnLocation_ground;

	// Start is called before the first frame update
	void Start()
	{
		Instantiate(clone, spawnLocation_ground, Quaternion.identity);
	}

	// Update is called once per frame
	void Update()
	{
		//change if to a time condition (night) and stop spawning once goal it met
		if (Input.GetKeyDown(KeyCode.T))
		{
			Instantiate(clone, spawnLocation_ground, Quaternion.identity);
		}



	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Nova"))
		{
			Debug.Log("The dragon hit you.");
			Destroy(clone);
			Instantiate(clone, spawnLocation_cas, Quaternion.identity);
			Player_Manager.health += 5;

		}
	}
}
