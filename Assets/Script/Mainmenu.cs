﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

public void PlayGame() {
		Application.LoadLevel(Application.loadedLevel);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

public void Mainmenus() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

public void Restart() {
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}

public void QuitGame(){
		Debug.Log("QUIT");
		Application.Quit();
	}
}
