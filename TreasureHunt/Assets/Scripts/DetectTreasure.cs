using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GVR;

public class DetectTreasure : MonoBehaviour {

	public Animator chestAnimation;
	public GameObject openSound;
	public GameObject conffetiFx;
	public GameObject yaySounds;



	void Start() {
		openSound.SetActive(false);
		conffetiFx.SetActive(false);
		yaySounds.SetActive(false);
	}

	void Update()
	{

	}

	public void FindTreasure() {
		chestAnimation.enabled = true;
		openSound.SetActive (true);
		conffetiFx.SetActive(true);
		yaySounds.SetActive(true);	
	}

}
