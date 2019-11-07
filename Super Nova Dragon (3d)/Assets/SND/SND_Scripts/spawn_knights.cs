using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_knights : MonoBehaviour
{
    public GameObject clone;
    public Vector3 spawnLocation;
    public float startTimer;
    public float timer;
	float xPos = 1.5f;
	public float timeBetweenEnemySpawns;

	// Start is called before the first frame update
	void Start()
    {
        timer += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //if (timer >= 500) { timer = 0f; }
        //startTimer += Time.deltaTime/200f;

		//if (startTimer >= 500) timer += Time.deltaTime;
		//Vector3 pos = new Vector3(Random.Range(-1f, 1f), xPos);

		//if (startTimer >= 500) timer += Time.deltaTime;
        //{ Instantiate(clone, spawnLocation, Quaternion.identity); }
		//{ Instantiate(clone, pos, Quaternion.identity); }

		if (timer > 0)
		{
			timer -= Time.deltaTime;
		}
		else
		{
			SpawnEnemy();
			timer = timeBetweenEnemySpawns;
		}
	}
	void SpawnEnemy()
	{
		// Vector2 pos = new Vector2(xPos, Random.Range(-3.5f, 3.4f));
		//Vector2 pos = new Vector2(Random.Range(-3.5f, 3.4f), xPos);
		Vector2 pos = new Vector2(Random.Range(-1.5f, 1.5f), xPos);
		//GameObject enemy = Instantiate(enemyPrefab, pos, enemyPrefab.transform.localRotation);
		GameObject enemy = Instantiate(clone, pos, clone.transform.localRotation);
	}
	}
