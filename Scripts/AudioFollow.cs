using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFollow : MonoBehaviour {
	public GameObject   player;
	public Vector3     position;

	void Start () {
		position = transform.position - player.transform.position;
	}


	void LateUpdate () 
	{
		transform.position = player.transform.position + position;
		//transform.LookAt (player.transform);
		//transform.rotation = player.transform.rotation;
	}
}
