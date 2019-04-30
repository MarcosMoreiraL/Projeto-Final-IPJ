using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInfo : MonoBehaviour {

	public string 			nomeObj;
	public int              subSpawn = 0;
	public Transform 		player;
	public Transform 		player2T;
	public float 			distPlayer;
	public float 			distPlayer2;
	public PlayerState 		player1;
	public PlayerState 		player2;
	public int   			pontos = 1;
	public int   			pontos2 = 1;

	public ObjController	controle;
	public PlayerState		playerState;

	// Use this for initialization
	void Start () 
	{
		controle = GameObject.Find ("SpawnControl").GetComponent<ObjController>();
		player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		player2 = GameObject.Find ("Player2").GetComponent<PlayerState> ();
		player2T = GameObject.Find("Player2").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		distPlayer = player.position.z - transform.position.z;
		distPlayer2 = player2T.position.z - transform.position.z;
	}

	void Update () 
	{


		if(distPlayer >= 6f)
		{
			player1.respawnPosition = new Vector3(transform.position.x,transform.position.y + 10,transform.position.z);
			player1.pontPlataformas+=pontos;
			player1.platFaltando-=pontos;
			pontos = 0;
		}

			if(distPlayer2 >= 6f)
		{
			player2.respawnPosition = new Vector3(transform.position.x,transform.position.y + 10,transform.position.z);
			player2.pontPlataformas+=pontos2;
			player2.platFaltando-=pontos2;
			pontos2 = 0;
		}

		if (distPlayer >= 60f || distPlayer2 >= 60f) 
		{
			destroy ();
		} else 
		{
			subSpawn = 0;
		}
	}


	public void destroy()
	{
		Destroy (gameObject);
		controle.spawnCount -= 2;
	}



}
