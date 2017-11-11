using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorPlayerScript : MonoBehaviour {

	public Animator m_Animator;
	private bool spaceDown = false;											//if umbrella is open or closed
	private float passed = 0;												//to keep track of how long the player has used the umbrella
	public float maxPassed = 3;												//maximum amount of time the player can keep the umbrella open
	public Animator health2; 
	private int Health = 3;

	// Use this for initialization
	void Start () {
		m_Animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && passed <= maxPassed) {			//opens umbrella when space is pressed and passed is less than or equal to maxPassed
			spaceDown = true;
		} 
		if (spaceDown) {													//When the umbrella is closed, 
			m_Animator.SetBool ("spaceDown", true);
		}
		if (passed > maxPassed || Input.GetButtonUp ("Jump")) {				//closes umbrella when space is released or passed is greater than max
			spaceDown = false;
		}
		if (!spaceDown) {													//When the Umbrella is closed,
			m_Animator.SetBool ("spaceDown", false);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision) {					//when the player collides
		if (collision.CompareTag ("Enemy")) {								//with an enemy
			collision.gameObject.SetActive (false);							//despawn enemy
			//loseText.text = "You Lose!";
			m_Animator.SetTrigger ("Hit");									//animate player for being hit
			Health -= 1;
			Debug.Log (Health);
			health2.SetInteger ("Health", Health);
		}
	}
}