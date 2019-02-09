using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingLevel : MonoBehaviour {

	int numGamePanels = 3;

	void Start () {
		GameObject[] Obstacles = GameObject.FindGameObjectsWithTag("obstacle");

		foreach(GameObject obstacle in Obstacles) {
			Vector3 pos = obstacle.transform.position;
			obstacle.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered" + collider.name);
		float heightOfGameObject = ((BoxCollider2D)collider).size.y;
		Vector3 pos = collider.transform.position;
		pos.y += heightOfGameObject * numGamePanels;

		if(collider.tag == "obstacle") {
			pos.y = pos.y + (95 - 20);
		}

		collider.transform.position = pos;

	}
}
