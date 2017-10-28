using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	private Rigidbody2D rb2d;
	public Rigidbody2D player;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		rb2d.position = new Vector2 (0, player.position.y - 3);  //makes it so the camera follows player on y axis, but not x axis
	}
}