using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float playerSpeed = 10;											//scaler for how fast the player's vertical movement is
	private float passed = 0;												//to keep track of how long the player has used the umbrella
	public float maxPassed = 3;												//maximum amount of time the player can keep the umbrella open
	private float ussage;													//used to convert passed  to a percentage before showing it to the player
	private bool spaceDown = false;											//if umbrella is open or closed
	public float umbDrag = 3;												//drag when umbrella is open
	public float regDrag = 1;												//drag when umbralla is closed
	//public double acceleration = 0.5;										//acceleration of player
	public UnityEngine.UI.Text ussageText;									//text to display umbrella usage

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.drag = regDrag;												//sets starting drag to that of the closed umbrella
		//rb2d.gravityScale = 0;
	}

	void Update () {
		//acceleration = acceleration * ((1 + Time.deltaTime) / 10);
		//rb2d.gravityScale = rb2d.gravityScale + Time.deltaTime * ((float)acceleration/10); //accelerates player 
		if (Input.GetButtonDown ("Jump") && passed <= maxPassed) {			//opens umbrella when space is pressed and passed is less than or equal to maxPassed
			spaceDown = true;

		} 
		if (spaceDown) {													//When the umbrella is closed, 
			rb2d.drag = umbDrag;											//the drag changes to the umbrella's open drag
			passed += Time.deltaTime;										//passed increases by time passed
		}
		if (passed > maxPassed || Input.GetButtonUp ("Jump")) {				//closes umbrella when space is released or passed is greater than max
			spaceDown = false;
		}
		if (!spaceDown) {													//When the Umbrella is closed,
			rb2d.drag = regDrag;											//the drag changes to the umbrella's closed drag
			passed -= Time.deltaTime / 2;
		}
		if (passed < 0) {													//Makes sure the umbrella meter does not decrease past zero
			passed = 0;
		}
		Vector2 move = new Vector2 (Input.GetAxis ("Horizontal"), 0);		//player input for movement in the x direction
		rb2d.AddForce(playerSpeed * move);									//adds force to move player
		ussage = passed * 100 / maxPassed;									//converts the amount of time a player has used their umbrella to a percentage 
		ussageText.text = ussage.ToString ("00") + "%";						//showing player their umbrella ussage in percentage
	}
}