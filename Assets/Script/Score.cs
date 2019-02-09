using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	private void OnTriggerEnter2D (Collider2D other) {
		if (other.GetComponent<Player>() != null) {
			GameControl.instance.PlayerScored();
			if (other.GetComponent<Player>() == null) {
				Destroy(other.GetComponent<Player>());
			}
		}
	}
}
