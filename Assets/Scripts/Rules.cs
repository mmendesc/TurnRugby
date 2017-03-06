using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour {

	private GameObject ball;
	private float position_before;
	private float position_after;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		//Debug.Log(col.gameObject.transform.position.x);
		if (col.gameObject.tag == "AttackingPlayer") {
			//Debug.Log(string.Concat(col.gameObject.name, " Is Offside"));
			position_before = col.gameObject.transform.position.x;
		}
	}

	void OnTriggerExit2D(Collider2D col) { 
		//Debug.Log(col.gameObject.transform.position.x);
		if (col.gameObject.tag == "AttackingPlayer")
		{
			position_after = col.gameObject.transform.position.x;

			//Debug.Log(string.Concat(position_after, " valor depois"));
			//Debug.Log(string.Concat(position_before, " valor antes"));
			if (position_after > position_before)	{
				Debug.Log(string.Concat(col.gameObject.name, " Is still Offside"));
			}
			else { 
				Debug.Log(string.Concat(col.gameObject.name, " Is Onside Again"));
			}

		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "AttackingPlayer") { 
			//Debug.Log(string.Concat(col.gameObject.name, " Is Offside"));
			//Debug.Log(string.Concat(position_before, " valor antes"));
		}

	}
}
