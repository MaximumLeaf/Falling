using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float playerSpeed = 10;
	public int umb;							//Increment counter for umbrella usage
	private float passed = 0;
	public bool spaceDown = false;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && passed <= 3) {				//opening umbrella
			spaceDown = true;
		} 

		if (spaceDown) {
			passed += Time.deltaTime;

		}
			
		if (passed < 3 && spaceDown) {
			rb2d.drag = 3;
		}

		if (passed > 3 || Input.GetButtonUp ("Jump")) {
			spaceDown = false;
		}

		if (!spaceDown) {				//closing umbrella
			rb2d.drag = 1;
			passed -= Time.deltaTime;
		}
		if (passed < 0) {
			passed = 0;
		}
		Vector2 move = new Vector2 (Input.GetAxis ("Horizontal"), 0);		//left and right movement
		rb2d.AddForce(playerSpeed * move);
		//print (passed);
	}
}