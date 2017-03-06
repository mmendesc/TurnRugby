using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private GameObject player;
	private bool isCarried;
	private int activePlayer;
	// Use this for initialization
	void Start () {
		activePlayer = PlayerController.activePlayer + 1;
		player = GameObject.Find(string.Concat("Player", activePlayer));
		isCarried = false;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		activePlayer = PlayerController.activePlayer + 1;
		player = GameObject.Find(string.Concat("Player", activePlayer));


		if (Input.GetKeyDown(KeyCode.B)) {
			isCarried = true;
			this.transform.position = player.transform.position+ new Vector3(0.309f,0,0);
		}

		if (isCarried) { 
			this.transform.position = player.transform.position + new Vector3(0.309f, 0, 0);
		}
	}
}
