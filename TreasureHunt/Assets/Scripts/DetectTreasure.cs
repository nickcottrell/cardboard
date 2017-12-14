using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GVR;

public class DetectTreasure : MonoBehaviour {

	public Animator chestAnimation;
	public GameObject openSound;
	public GameObject conffetiFx;
	public GameObject yaySounds;
	public GameObject booSounds;
	public GameObject lockedMsg;
	public GameObject keyPickUpMsg;
	public GameObject keyPrefab;
	public GameObject youWinMsg;


	private bool isUnlocked = false;


	void Start() {
		openSound.SetActive(false);
		conffetiFx.SetActive(false);
		yaySounds.SetActive(false);
		booSounds.SetActive(false);
		lockedMsg.SetActive(false);
		keyPickUpMsg.SetActive(false);
		youWinMsg.SetActive(false);

	}

	void Update()
	{

	}


	public void unlock() {
		isUnlocked = true;
		Destroy (keyPrefab);
		keyPickUpMsg.SetActive (true);
		lockedMsg.SetActive (false);



	}

	public void FindTreasure() {
		if (isUnlocked == true) {
			chestAnimation.enabled = true;
			openSound.SetActive (true);
			conffetiFx.SetActive (true);
			yaySounds.SetActive (true);	
			youWinMsg.SetActive(true);

		} else {
			booSounds.SetActive (true);
			lockedMsg.SetActive (true);
		}

	}

}
