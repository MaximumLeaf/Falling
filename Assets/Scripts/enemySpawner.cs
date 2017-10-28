using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

	public GameObject enemy;
	float randX;
	float randSpawn;
	Vector2 whereToSpawn; 
	public float spawnRate = 2f;
	float nextSpawn = 2.0f;
	float timeLastSpawn = 0.0f;
	Rigidbody2D rb2d;
	public Rigidbody2D player;
	public Rigidbody2D cam;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		randSpawn = Random.Range (1,3); 
		timeLastSpawn += Time.deltaTime;
		if (timeLastSpawn > nextSpawn) {
			nextSpawn = spawnRate * randSpawn;
			randX = Random.Range (-4.5f, 4.5f);
			whereToSpawn = new Vector2 (randX, player.position.y - 10);
			Instantiate (enemy, whereToSpawn, Quaternion.identity);
			timeLastSpawn = 0;
		}
	}
	void OnBecameInvisible(){											//only activates when backgrounds are out of frames
		if (cam.transform.position.y < rb2d.transform.position.y) {
			Destroy (enemy,0f);
		}
	}
}
