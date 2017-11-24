using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//get rotation value from phone
		Quaternion att = Input.gyro.attitude;
		//offset the value to account for head position
		att = Quaternion.Euler (90f, 0f, 0f) * new Quaternion (att.x, att.y, -att.z, -att.w);
		//assign rotation to camera
		transform.rotation = att;
	}
}
