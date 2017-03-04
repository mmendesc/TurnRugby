using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprites : MonoBehaviour {

	public Sprite inactive;
	public Sprite active;
	private int active_number;
	private int position;
	// Use this for initialization
	void Start () {
		active_number = PlayerController.activePlayer+1;
		position = this.GetComponent<PlayerStats>().playerPosition;

		if (active_number == position)
		{
			this.GetComponent<SpriteRenderer>().sprite = active;
		}
		else { 
			this.GetComponent<SpriteRenderer>().sprite = inactive;
		}
	}
	
	// Update is called once per frame
	void Update () {
		active_number = PlayerController.activePlayer + 1;

		if (active_number == position)
		{
			this.GetComponent<SpriteRenderer>().sprite = active;
		}
		else {
			this.GetComponent<SpriteRenderer>().sprite = inactive;
		}
	}
}
