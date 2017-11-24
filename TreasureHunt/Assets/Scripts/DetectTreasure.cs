using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GVR;

public class DetectTreasure : MonoBehaviour {

	public Animator chestAnimation;
	public GameObject openSound;
	public GameObject conffetiFx;
	public GameObject yaySounds;

	RaycastHit hit;
	Ray ray;



	void Start() {
		chestAnimation.StartPlayback ();
		openSound.SetActive(false);
		conffetiFx.SetActive(false);
		yaySounds.SetActive(false);
	}

	void Update()
	{
		//Vector3 fwd = transform.TransformDirection(Vector3.forward);

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//bool isPressed = GvrController.AppButtonDown;
		if (Physics.Raycast (ray, out hit)) {
			string lookyThing = hit.collider.gameObject.name;
			//if (lookyThing == "Chest" && isPressed == true) {
			if (lookyThing == "Chest") {
				chestAnimation.StopPlayback ();
				openSound.SetActive (true);
				conffetiFx.SetActive(true);
				yaySounds.SetActive(true);
			}
		}

		//if (Physics.Raycast (transform.position, fwd, 10)) {
		//	Debug.Log(hit.collider.gameObject.name);
			//chestAnimation.StopPlayback ();
			//openSound.SetActive(true);
		//}
	}
}
