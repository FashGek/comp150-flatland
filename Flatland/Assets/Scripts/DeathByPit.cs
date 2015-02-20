﻿using UnityEngine;
using System.Collections;

public class DeathByPit : MonoBehaviour {

	private GameController gameController;
	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent <GameController> ();
		}
		if (gameController == null) {
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Destroy (other.gameObject);
			gameController.Died ();
		}
	}
}
