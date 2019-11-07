using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour {

	public GameObject enemy;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;
	public int spawnTotal;
	private int counter;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("Spawn", spawnTime, spawnTime);

		
	}

	void Spawn(){
		if (counter < spawnTotal) {

			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			counter++;
		}
	}





	}
	// Update is called once per frame
