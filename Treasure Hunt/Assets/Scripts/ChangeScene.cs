﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void GoToScene(string SceneName) {
		Debug.Log ("My method was called.");
		SceneManager.LoadScene (SceneName);
	}

}
