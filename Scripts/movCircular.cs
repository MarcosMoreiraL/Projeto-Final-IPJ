using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCircular : MonoBehaviour {

public Vector3 velocidade;


	void Start () {
		
	}
	

	void Update () {
		transform.position = transform.position + velocidade;
}
}