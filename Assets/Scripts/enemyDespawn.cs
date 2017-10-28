using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDespawn : MonoBehaviour {

	Rigidbody2D rb2d;
	public Rigidbody2D cam;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameInvisible(){											//only activates when backgrounds are out of frames
		if (cam.transform.position.y < rb2d.transform.position.y) {
			Destroy (gameObject);
		}
	}
}
