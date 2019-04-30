using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObs : MonoBehaviour {
	public Vector3 velocidadePos;
	public float   tempo;
	public float   tempoFinal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + velocidadePos;

		if (tempo >= tempoFinal) {
			velocidadePos = -velocidadePos;
			tempo = 0f;
			tempoFinal = tempoFinal + 3;
		} else 
		{
			tempo = Time.time;
		}
	}
}
