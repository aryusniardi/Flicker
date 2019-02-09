using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPause = false;

	public GameObject pauseMenuUI;
	public GameObject pauseButtonUI;

	void Start () {
		pauseMenuUI.SetActive(false);
		pauseButtonUI.SetActive(true);
	}
	public void PauseGame() {
		if (GameIsPause) {
			Pause();
		} else {
			Resume();
		}
	}

	void Resume() {
		pauseMenuUI.SetActive(true);
		pauseButtonUI.SetActive(false);
		Time.timeScale = 0f;
		GameIsPause = true;
	}

	void Pause () {
		pauseMenuUI.SetActive(false);
		pauseButtonUI.SetActive(true);
		Time.timeScale = 1f;
		GameIsPause = false;
	}
}
