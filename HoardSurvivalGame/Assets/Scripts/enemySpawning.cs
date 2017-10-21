using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour {

	public GameObject Enemy;
	public Transform spawnLocation;

	private Vector3 initLocation;
	private int enemycount = 0;
	private int maxEnemyCount = 7;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SpawnEnemy ();
	}

	void SpawnEnemy () {
		int randomLocX = Random.Range (-40, 41);
		int randomLocZ = Random.Range (-40, 41);

		initLocation = new Vector3 (randomLocX + spawnLocation.position.x, 1.25f, randomLocZ + spawnLocation.position.z);

		Instantiate (Enemy, initLocation, Quaternion.identity);
	}
}
