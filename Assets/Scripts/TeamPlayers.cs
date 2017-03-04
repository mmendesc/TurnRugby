using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamPlayers : MonoBehaviour {


	public List<GameObject> players = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 3; i++) {
			
			players.Add(GameObject.Find(string.Concat("Player", i+1)));


		}
		Debug.Log(players[1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
