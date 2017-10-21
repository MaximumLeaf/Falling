using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiling : MonoBehaviour {

	public Vector2 backpos;
	private float y;
	private float height = 12f;										//height of background
	public Rigidbody2D cam;

	void OnBecameInvisible(){										//only activates when backgrounds are out of frames
		if (cam.transform.position.y < transform.position.y){		//only activates when the camera is below the background
			backpos = transform.position;							//finds the y position of background
			y = backpos.y - height * 2;								//Calculates new y position for background
			transform.position = new Vector2(backpos.x, y);			//moves background to new position
		}
	}
}
