using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {


	public Animator chestOpening;
	public AudioSource soundSource2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void OnChestClick() {
		chestOpening.enabled = true;
		soundSource2.enabled = true;
	}
}
