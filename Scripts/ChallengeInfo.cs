using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeInfo : MonoBehaviour {

	public string 			nomeObj;
	public int              subSpawn = 0;
	public Transform 		player;
	public Transform 		player2T;
	public float 			distPlayer;
	public float 			distPlayer2;
	public PlayerState 		player1;
	public PlayerState 		player2;
	public int   			pontos = 3;
	public int   			pontos2 = 3;

	public ObjController	controle;

	public Renderer[] 		wall1;
	public Renderer[] 		wall2;

	public Light 			luz;

	public Color[]        	wallCollor;
	public int				colorCount = 0;

	// Use this for initialization
	void Start () 
	{
		controle = GameObject.Find ("SpawnControl").GetComponent<ObjController>();
		//player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		player2 = GameObject.Find ("Player2").GetComponent<PlayerState> ();
		player2T = GameObject.Find("Player2").GetComponent<Transform> ();

		wall1 [0] = GameObject.Find ("Wall3").GetComponent<Renderer>();
		wall1 [1] = GameObject.Find ("Wall4").GetComponent<Renderer>();

		wall2 [0] = GameObject.Find ("Wall3.2").GetComponent<Renderer>();
		wall2 [1] = GameObject.Find ("Wall4.2").GetComponent<Renderer>();

		//luz = GameObject.Find ("Directional Light").GetComponent<Light> ();

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		distPlayer = player.position.z - transform.position.z;
		distPlayer2 = player2T.position.z - transform.position.z;
	}

	void Update () 
	{

		if ((distPlayer >= -3 && distPlayer <= 3) || (distPlayer2 >= -3 && distPlayer <= 3)) 
		{
			wall1 [0].material.color = Color.blue;
			wall1 [1].material.color = Color.blue;

			wall2 [0].material.color = Color.blue;
			wall2 [1].material.color = Color.blue;
		}

		if (distPlayer >= 6 || distPlayer2 >= 6) 
		{
			wall1 [0].material.color = wallCollor[colorCount];
			wall1 [1].material.color = wallCollor[colorCount];

			wall2 [0].material.color = wallCollor[colorCount];
			wall2 [1].material.color = wallCollor[colorCount];

			luz.color += Color.blue;
		}
			
		if (distPlayer >= -2) 
		{
			player1.platFaltando = 0;
		}

		if (distPlayer2 >= -2) 
		{
			player2.platFaltando = 0;
		}

		if(distPlayer >= 6f)
		{
			player1.respawnPosition = new Vector3(transform.position.x,transform.position.y + 3,transform.position.z);
			player1.pontPlataformas+=pontos;
			player1.platFaltando = 10;
			pontos = 0;
		}

		if(distPlayer2 >= 6f)
		{
			player2.respawnPosition = new Vector3(transform.position.x,transform.position.y + 3,transform.position.z);
			player2.pontPlataformas+=pontos;
			player2.platFaltando = 10;
			pontos = 0;
		}

		if(distPlayer2 >= 6f)
		{
			player2.respawnPosition = new Vector3(transform.position.x,transform.position.y + 3,transform.position.z);
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
		controle.spawnCount -= 1;
	}		
}
