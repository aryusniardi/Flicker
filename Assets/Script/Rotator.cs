using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed = 100f;

	void Start() {
		speed = Random.Range(10f, 30f);
		speed = speed + GameControl.instance.score;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 0f, speed * Time.deltaTime);
	}
}
