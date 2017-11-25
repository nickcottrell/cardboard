using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;
	public GameObject coinPrefab;
	public GameObject coinAudio;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Vector3 coinposition = transform.position; 
		Object.Instantiate(coinPoofPrefab, coinposition, Quaternion.Euler(-90, 0, 0));
		Object.Instantiate(coinAudio, coinposition, Quaternion.Euler(-90, 0, 0));
		Destroy(coinPrefab);

	
	}

}
