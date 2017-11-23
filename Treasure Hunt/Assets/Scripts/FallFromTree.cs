using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Move the coconut down every frame until it hits the ground, then stop.
public class FallFromTree : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0, 5 + Mathf.Sin (Time.time * 5.0f),0);
	}
}
