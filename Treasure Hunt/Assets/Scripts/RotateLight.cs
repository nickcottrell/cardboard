using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

	public GameObject directionalLight;

	float startTime = 0f;
	bool isPressed = false; //has the cardboard trigger been pressed at least once? this flag switches just once.


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// if the button is pressed and hasn't already been pressed yet
		if (Input.GetMouseButtonDown (0) && !isPressed) {
			isPressed = true;
		}

		//do the mathy rotation stuff
		Quaternion startRotation = Quaternion.Euler (50f, -30f, 0f);
		Quaternion endRotation = startRotation * Quaternion.Euler (0f, 180f, 0f);  // Multiplying two Quaternions together adds the rotations

		if (isPressed) { //once this flag switches, engage in the sunset action...
			
			directionalLight.transform.rotation = Quaternion.Slerp (startRotation, endRotation, startTime / 10f);
			startTime += Time.deltaTime;
		}

	}
}
