using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiling : MonoBehaviour {

	public Vector2 backpos;
	private float y;
	public float height = 11.52f;
	public Rigidbody2D cam;


	void OnBecameInvisible(){
		if (cam.transform.position.y < transform.position.y){
			backpos = transform.position;
			y = backpos.y - height * 2;
			transform.position = new Vector2(backpos.x, y);
			print (y);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
