using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjController : MonoBehaviour {
	public int 				curPlat,spawnInicial,limiteSpawn,spawnCount,numObj,idObj,currentSpawn;
	public string 			nomeObj, nObj;
	public float 			zPos, dist;
	public GameObject 		obs1,obs2,obs3,obs4,obs5,obs6,obs7,obs8,obs9,obs10,obs11,obs12,obs13,obs14,obs15,obs16;
	public GameObject 		challenge1, challenge2;

	public ObjInfo    		objInfo;
	public ChallengeInfo    challengeInfo;

	public PlayerState 		player1;
	public PlayerState 		player2;

	public Transform player;

	// Use this for initialization
	void Start () 
	{
		dist = 0;
		zPos = 149;
		currentSpawn = 0;
		spawnInicial = 0;

		player = GameObject.Find ("Player1").transform;
		player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		player2 = GameObject.Find ("Player2").GetComponent<PlayerState> ();
	}
		

	// Update is called once per frame
	void Update () 
	{

		if (spawnCount <= limiteSpawn) 
		{
			if (currentSpawn < 10) {
				spawnInicial = 0;
				limiteSpawn = 10;
			} else if (currentSpawn > 10 && currentSpawn <= 20) {
				spawnInicial = 11;
				limiteSpawn = 20;
			} else if (currentSpawn > 21) {
				spawnInicial = 1;
				limiteSpawn = 20;
			}

			if (currentSpawn == 9) {
				curPlat = 0;
				currentSpawn ++;
				SpawnChallenge1 ();
				zPos = zPos + dist;

				Debug.Log ("Desafio Spawnado");
				spawnCount++;
			} else if (currentSpawn == 19) {
				curPlat = 0;
				currentSpawn ++;
				SpawnChallenge2 ();
				zPos = zPos + dist;

				Debug.Log ("Desafio 2 Spawnado");
				spawnCount++;
			} else 
			{
				curPlat = Random.Range (spawnInicial, limiteSpawn);
			}
				
			if (curPlat == 1)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs1 ();
				zPos = zPos + dist;
			}

			if (curPlat == 2)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs2 ();
				zPos = zPos + dist;
			}

			if (curPlat == 3)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs3 ();
				zPos = zPos + dist;
			}

			if (curPlat == 4)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs4 ();
				zPos = zPos + dist;
			}

			if (curPlat == 5)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs5 ();
				zPos = zPos + dist;
			}

			if (curPlat == 6)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs6 ();
				zPos = zPos + dist;
			}
			if (curPlat == 7)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs7 ();
				zPos = zPos + dist;
			}

			if (curPlat == 8)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs8 ();
				zPos = zPos + dist;
			}

			if (curPlat == 9)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs9 ();
				zPos = zPos + dist;
			}


			if (curPlat == 10)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs10 ();
				zPos = zPos + dist;
			}


			if (curPlat == 11)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs11 ();
				zPos = zPos + dist;
			}


			if (curPlat == 12)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs12 ();
				zPos = zPos + dist;
			}


			if (curPlat == 13)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs13 ();
				zPos = zPos + dist;
			}


			if (curPlat == 14)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs14 ();
				zPos = zPos + dist;
			}


			if (curPlat == 15)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs15 ();
				zPos = zPos + dist;
			}


			if (curPlat == 16)
			{
				currentSpawn ++;
				spawnCount ++;
				SpawnObs16 ();
				zPos = zPos + dist;
			}
		}
	}

	void SpawnObs1()
	{
		
		Vector3 spawnPoint = new Vector3 (469.945f,  13f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 8f;

		GameObject obs1Clone = Instantiate (obs1, spawnPoint, spawnRot);
		ObjInfo objInfo = obs1Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs1Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "1";
	}

	void SpawnObs2()
	{
		
		Vector3 spawnPoint = new Vector3 (469.945f,  7.398f, zPos);
		Quaternion spawnRot = new Quaternion (-29.853f, 0, 0, 1);
		dist = 11f;

		GameObject obs2Clone = Instantiate (obs2, spawnPoint, spawnRot);
		ObjInfo objInfo = obs2Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs2Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "2";
	}

	void SpawnObs3()
	{
		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 28f;

		GameObject obs3Clone = Instantiate (obs3, spawnPoint, spawnRot);
		ObjInfo objInfo = obs3Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs3Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "3";
	}

	void SpawnObs4()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 15f;

		GameObject obs4Clone = Instantiate (obs4, spawnPoint, spawnRot);
		ObjInfo objInfo = obs4Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs4Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "4";
	}

	void SpawnObs5()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 25f;

		GameObject obs5Clone = Instantiate (obs5, spawnPoint, spawnRot);
		ObjInfo objInfo = obs5Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs5Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "5";
	}

	void SpawnObs6()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 9.5f;

		GameObject obs6Clone = Instantiate (obs6, spawnPoint, spawnRot);
		ObjInfo objInfo = obs6Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs6Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "6";
	}

	void SpawnObs7()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 10f;

		GameObject obs7Clone = Instantiate (obs7, spawnPoint, spawnRot);
		ObjInfo objInfo = obs7Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs7Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "7";
	}

	void SpawnObs8()
	{


		Vector3 spawnPoint = new Vector3 (469.945f,  11.5f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 14f;

		GameObject obs8Clone = Instantiate (obs8, spawnPoint, spawnRot);
		ObjInfo objInfo = obs8Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs8Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "8";
	}

	void SpawnObs9()
	{

		dist = 15f;
		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);

		GameObject obs9Clone = Instantiate (obs9, spawnPoint, spawnRot);
		ObjInfo objInfo = obs9Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs9Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "9";
	}

	void SpawnObs10()
	{


		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 15f;

		GameObject obs9Clone = Instantiate (obs9, spawnPoint, spawnRot);
		ObjInfo objInfo = obs9Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs9Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "10";
	}

	void SpawnObs11()
	{
		
		Vector3 spawnPoint = new Vector3 (469.945f,  13f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 11f;

		GameObject obs11Clone = Instantiate (obs11, spawnPoint, spawnRot);
		ObjInfo objInfo = obs11Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs11Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "11";
	}

	void SpawnObs12()
	{


		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 11f;

		GameObject obs12Clone = Instantiate (obs12, spawnPoint, spawnRot);
		ObjInfo objInfo = obs12Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs12Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "12";
	}

	void SpawnObs13()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (-33.726f, 0, 0, 1);
		dist = 11.5f;

		GameObject obs13Clone = Instantiate (obs13, spawnPoint, spawnRot);
		ObjInfo objInfo = obs13Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs13Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "13";
	}

	void SpawnObs14()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 11f;

		GameObject obs14Clone = Instantiate (obs14, spawnPoint, spawnRot);
		ObjInfo objInfo = obs14Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs14Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "14";
	}

	void SpawnObs15()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 14f;

		GameObject obs15Clone = Instantiate (obs15, spawnPoint, spawnRot);
		ObjInfo objInfo = obs15Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs15Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "15";
	}

	void SpawnObs16()
	{

		Vector3 spawnPoint = new Vector3 (469.945f,  15.398f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 12f;

		GameObject obs16Clone = Instantiate (obs16, spawnPoint, spawnRot);
		ObjInfo objInfo = obs16Clone.GetComponent<ObjInfo> ();
		objInfo.player = player;
		obs16Clone.name = "Plataforma" + (currentSpawn + 1).ToString();
		objInfo.nomeObj = "16";
	}

	void SpawnChallenge1()
	{
		dist = 20f;
		Vector3 spawnPoint = new Vector3 (469.945f,  15f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 20f;

		GameObject challenge1Clone = Instantiate (challenge1, spawnPoint, spawnRot);
		ChallengeInfo challengeInfo = challenge1Clone.GetComponent<ChallengeInfo> ();
		challengeInfo.player = player;
		challengeInfo.colorCount = 0;
		challengeInfo.player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		challengeInfo.luz = GameObject.Find ("Directional Light").GetComponent<Light> ();
		challengeInfo.wall1[0] = GameObject.Find ("Wall3").GetComponent<Renderer>();
		challengeInfo.wall1[1] = GameObject.Find ("Wall4").GetComponent<Renderer>();
		challenge1Clone.name = "Desafio";
		challengeInfo.nomeObj = "Challenge1";
	}

	void SpawnChallenge2()
	{
		dist = 25f;
		Vector3 spawnPoint = new Vector3 (469.945f,  15f, zPos);
		Quaternion spawnRot = new Quaternion (0, 0, 0, 0);
		dist = 28f;

		GameObject challenge2Clone = Instantiate (challenge2, spawnPoint, spawnRot);
		ChallengeInfo challengeInfo = challenge2Clone.GetComponent<ChallengeInfo> ();
		challengeInfo.player = player;
		challengeInfo.colorCount = 0;
		challengeInfo.player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		challengeInfo.luz = GameObject.Find ("Directional Light").GetComponent<Light> ();
		challengeInfo.wall1[0] = GameObject.Find ("Wall3").GetComponent<Renderer>();
		challengeInfo.wall1[1] = GameObject.Find ("Wall4").GetComponent<Renderer>();
		challenge2Clone.name = "Desafio";
		challengeInfo.nomeObj = "Challenge2";
	}
}
