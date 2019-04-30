using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public GameObject   player;
	public Vector3     position;

	void Start () {
		position = transform.position - player.transform.position;
	}
	
	void LateUpdate () 
	{
		transform.position = new Vector3(transform.position.x ,transform.position.y,player.transform.position.z + position.z);
		//transform.rotation = player.transform.rotation;
	}
}
