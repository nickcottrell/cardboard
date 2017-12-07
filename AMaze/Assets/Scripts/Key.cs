using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door

	public GameObject doorPrefab;
	public GameObject keyPoofPrefab;
	public GameObject keyPrefab;
	public GameObject keyAudio;

	 
	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)

	}




	public void OnKeyClicked()
	{
     


		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Vector3 keyposition = transform.position; 
		Object.Instantiate(keyPoofPrefab, keyposition, Quaternion.Euler(-90, 0, 0));
		Object.Instantiate(keyAudio, keyposition, Quaternion.Euler(-90, 0, 0));

		// Call the Unlock() method on the Door

		// Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(keyPrefab);

	}

}
