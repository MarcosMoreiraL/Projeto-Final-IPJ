using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObs : MonoBehaviour {
	public Vector3 velocidadeRot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (velocidadeRot.x * Time.deltaTime,velocidadeRot.y * Time.deltaTime,velocidadeRot.z * Time.deltaTime);
	}
}
