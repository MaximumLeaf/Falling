using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

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


}
