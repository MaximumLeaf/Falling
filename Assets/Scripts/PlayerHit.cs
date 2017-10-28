using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	public UnityEngine.UI.Text loseText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision) {

		if (collision.CompareTag ("Enemy")) {
			collision.gameObject.SetActive (false);
			loseText.text = "You Lose!";
		}
	}
}
