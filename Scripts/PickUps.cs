using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour {

	public PlayerState 		player1;
	void Start () {
		
		player1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter(Collision other)
	{
		//if (other.gameObject.CompareTag ("Player")) {
//this.gameObject.SetActive (false);
		//	player1.pontPickUps++;
		//}
	}
}
