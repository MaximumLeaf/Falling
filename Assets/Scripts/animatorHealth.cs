using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorHealth : MonoBehaviour {

	public Animator m_Animator;
	private int Health = 3;

	// Use this for initialization
	void Start () {
		m_Animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.CompareTag ("Enemy")) {
			collision.gameObject.SetActive (false);
			//loseText.text = "You Lose!";
			Health -= 1;
			m_Animator.SetInteger ("Health", Health);
		}
	}
}
