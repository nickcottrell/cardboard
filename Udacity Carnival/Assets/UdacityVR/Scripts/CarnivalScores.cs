using System;
using UnityEngine;
using TMPro;


public class CarnivalScores : MonoBehaviour {

	[SerializeField]
	private int TeddyBearPointsMin = 2000;

	float timeLeft = 60.0f;

	[SerializeField]
	private GameObject TeddyBear;

	[SerializeField]
	private GameObject TeddyParticleSystem;

	[SerializeField]
	private GameObject TeddyBearYay;

	[SerializeField]
	private GameObject TeddyBearSad;

	[SerializeField]
	private GameObject TeddyBearBoo;

	[SerializeField]
	private TextMeshPro plinkoScore;

	[SerializeField]
	private TextMeshPro wheelScore;

	[SerializeField]
	private TextMeshPro coinScore;

	[SerializeField]
	private TextMeshPro gameTimer;

	public static CarnivalScores Instance;

	private int plinkoPoints;
	private int wheelPoints;
	private int coinPoints;

	private bool gameIsActive;


	void Awake() {
		if (Instance == null)
			Instance = this;

			gameIsActive = true;
			TeddyBear.SetActive(false);
			TeddyParticleSystem.SetActive(false);
			TeddyBearYay.SetActive(false);
			TeddyBearSad.SetActive(false);
			TeddyBearBoo.SetActive(false);

	}
		
	void OnDestroy() {
		if (Instance = this)
			Instance = null;
	}
		
	// Update is called once per frame
	void Update () {
		plinkoScore.text = "Plinko: " + plinkoPoints.ToString("0000");
		wheelScore.text = "Wheel: " + wheelPoints.ToString("0000");
		coinScore.text = "Coins: " + coinPoints.ToString("0000");

		timeLeft -= Time.deltaTime;

		if (timeLeft > 0 & gameIsActive == true) {
			gameTimer.text = timeLeft.ToString("F0");
		} else if (timeLeft < 0 & gameIsActive == true) {
			TeddyBearSad.SetActive(true);
			TeddyBearBoo.SetActive(true);
			gameTimer.text = "Game Over!";
			gameIsActive = false;
		} else if (gameIsActive == false) {
			//do nothing
		}

		if (plinkoPoints + wheelPoints + coinPoints >= TeddyBearPointsMin & gameIsActive == true ) {
			gameTimer.text = "YOU WIN!";
			TeddyBear.SetActive(true);
			TeddyParticleSystem.SetActive(true);
			TeddyBearYay.SetActive(true);
			gameIsActive = false;
		}
	}

	public void IncrementPlinkoScore(float points) {
		if (gameIsActive == true) {
			plinkoPoints += (int)points;
		}
	}

	public void IncrementWheelScore(float points) {
		if (gameIsActive == true) {	
			wheelPoints += (int)points;
		}
	}

	public void IncrementCoinScore() {
		if (gameIsActive == true) {
			coinPoints += 1000;
		}
	}









}