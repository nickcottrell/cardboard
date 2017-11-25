using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	[SerializeField]
	public static bool locked;
	// Create a boolean value called "opening" that can be checked in Update() 

	public Animator doorOpening;

	void Start() {
		locked = true;
	}


    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up	
	}

    public void OnDoorClicked() {
		if (!locked) {
			Debug.Log("Opening the door...");
			doorOpening.enabled = true;
				} else {
					Debug.Log("Door is locked!");
						
				}
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
	}

    public void Unlock()
    {

		locked = false;
        // You'll need to set "locked" to false here

    }
}
