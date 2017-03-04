using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.
	public List<GameObject> players = new List<GameObject>();
	private PlayerStats[] stats;
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public static int activePlayer = 0;
	private TeamPlayers team;


	// Use this for initialization
	void Start()
	{
		team = GameObject.Find("Team").GetComponent<TeamPlayers>();
		players = team.players;

		rb2d = players[0].GetComponent<Rigidbody2D>();
		Debug.Log(rb2d,gameObject);
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Use the two store floats to create a new Vector2 variable movement.
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.MovePosition(rb2d.position + movement * Time.fixedDeltaTime * speed);

		if (Input.GetKeyDown(KeyCode.P))
		{
			
			rb2d.MovePosition(new Vector2(1, 1));

		}

		if (Input.GetKeyDown(KeyCode.C))
		{
			if (activePlayer >= players.Count-1)
				activePlayer = 0;
			else 
				activePlayer++;
				
			rb2d = players[activePlayer].GetComponent<Rigidbody2D>();
			
		}
	}




void Update()
	{ 
	
	
	}
		

}
