using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeathControl : MonoBehaviour {

	public PlayerState 		estePlayer;
	public Transform   		outroPlayer;

	public float 	    	dist;
	       
	void Start () 
	{
			
	}
	
	void FixedUpdate () 
	{
		dist = outroPlayer.position.z - transform.position.z;
	}

	void Update () 
	{
		if (dist >= 55f)
		{
			estePlayer.lives = 0;
		}
	}
}
