using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight2 : MonoBehaviour {

	public GameObject directionalLight;
	public Animator sunRotationAnimation;

	//float startTime = 0f;
	bool isPressed = false; //has the cardboard trigger been pressed at least once? this flag switches just once.

	// Use this for initialization
	void Start () {
		sunRotationAnimation.StartPlayback ();
	}

	// Update is called once per frame
	void Update () {
		// if the button is pressed and hasn't already been pressed yet
		if (Input.GetMouseButtonDown (0) && !isPressed) {
			isPressed = true;
		}

		if (isPressed) { //once this flag switches, engage in the sunset action...

			sunRotationAnimation.StopPlayback ();
			sunRotationAnimation.SetBool ("ChangeColor", true); // << this part is broken, not sure what's going on with that.
		}

	}
}
