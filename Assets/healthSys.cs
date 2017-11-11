using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSys : MonoBehaviour {

	private int maxHeartAmount = 3;
	private int startHearts = 3;
	public int curHealth;
	private int maxHealth;
	private int healthPerHeart = 1;

	public ImagePosition[] healthImages;
	public Sprite[] healthSprites;

	// Use this for initialization
	void Start () {
		curHealth = startHearts * healthPerHeart;
		maxHealth = maxHeartAmount * healthPerHeart;
	}

	//	void checkHeartAmount () {
	//		for (int i = 0; i < maxHeartAmount; i++) {
	//			if (startHearts <= i) {
	//				healthImages [i].enabled = false;
	//			} 
	//			else {
	//				healthImages [i].enabled = true;
	//			}
	//		}
	//	}
	void UpdateHearts(){
		bool empty = false;
		int i = 0;


	}
	//http://www.youtube.com/watch?v=CBjpiNYDecQ
	//36:41
}
