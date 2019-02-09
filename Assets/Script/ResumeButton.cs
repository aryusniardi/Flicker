using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : MonoBehaviour {

	public static bool GameIsPause = true;

	public GameObject pauseMenuUI;
	public GameObject pauseButtonUI;

	void Start () {
		pauseMenuUI.SetActive(true);
	}

	public void ResumeGame() {
		if (GameIsPause) {
			Resume();
		} else {
			Pause();
		}
	}

	void Resume() {
		pauseMenuUI.SetActive(false);
		pauseButtonUI.SetActive(true);
		Time.timeScale = 1f;
		GameIsPause = true;
	}

	void Pause () {
		pauseMenuUI.SetActive(true);
		pauseButtonUI.SetActive(false);
		Time.timeScale = 0f;
		GameIsPause = false;
	}
}
