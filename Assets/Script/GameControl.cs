using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public int score = 0;
	public int highscore;

	public static GameControl instance;
	public Text scoreText;
	public Text highscoreText;
	public GameObject gameOverText;
	public GameObject pauseButtonUI;
	public bool gameOver = false;

	// Use this for initialization
void Start () {

}
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
				Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerScored() {
		if(gameOver) {
			return;
		}
		score++;
		scoreText.text = score.ToString();
		if (score > highscore) {
			highscore = score;
			PlayerPrefs.SetInt("HighscoreText", score);
		}
	}

	public void PlayerDied() {
			gameOverText.SetActive (true);
			gameOver = true;
			pauseButtonUI.SetActive (false);
			highscoreText.text = "Highscore " + PlayerPrefs.GetInt("HighscoreText").ToString();
	}
}
