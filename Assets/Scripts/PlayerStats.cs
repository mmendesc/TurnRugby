using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public enum PlayerPositions { 
		LooseProp=1,
		Hooker=2,
		TightProp=3,
		Lock4=4,
		Lock5=5,
		BlindFlanker=6,
		OpenFlanker=7,
		Eight=8,
		ScrumHalf=9,
		FlyHalf=10,
		LeftWing=11,
		InsideCentre=12,
		OutsideCentre=13,
		RightWing=14,
		Fullback=15
	
	}

	public int speed;
	public int stamina;
	public int kickAbility;
	public int passAbility;
	public float catchAbility;
	public int tackleAbility;
	public int playerPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
