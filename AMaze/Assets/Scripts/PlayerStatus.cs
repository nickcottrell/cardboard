using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

	public int coinNumber = 0;
	public bool keyCollected;

	// Use this for initialization
	void Start () {
		keyCollected = false;	
	}
	
	// Update is called once per frame
	void Update () {

	}


	public void KeyCollection() {
		keyCollected = true;	
	}


	public void CoinTally() {
		coinNumber = coinNumber + 1; 
		Debug.Log (coinNumber);
	}


}
