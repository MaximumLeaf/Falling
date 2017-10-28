using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

	public GameObject enemy;
	float randX;
	Vector2 whereToSpawn; 
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	Rigidbody2D rb2d;
	public Rigidbody2D player;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (-4.5f, 4.5f);
			whereToSpawn = new Vector2 (randX, player.position.y - 10);
			Instantiate (enemy, whereToSpawn, Quaternion.identity);
		}
	}
}
