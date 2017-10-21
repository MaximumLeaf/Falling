using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	private Rigidbody2D rb2d;			//make it so the camera follows player on y axis, but not x axis
	public Rigidbody2D player;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.position = new Vector2 (0, player.position.y);
	}
}
