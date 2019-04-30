using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PlayerState : MonoBehaviour {

	public Text             pontuacao;
	public Text             pickUpsPT;
	public Text				platFaltandoTXT;
	public Text             platSuperadas;
	public int         		pontPickUps;
	public int 		   		pontPlataformas;
	public int              pontuacaoTotal;
	public int              platFaltando;
	public bool				isDead;
	public Vector3 			respawnPosition;
	public int              lives;
	public Text             vidasTXT;

	public AudioSource      dieAs;
	public AudioSource      collisionAs;
	public AudioSource 		splashAS;
	public AudioSource      pickUpAs;


	public AudioClip        dieSound;
	public AudioClip 		collSound;
	public AudioClip		splashSound;
	public AudioClip        pickUpSound;

	public AudioMixer       mixer;

	void Start () 
	{
		respawnPosition = transform.position;
		dieAs = GameObject.Find ("AudioMaster").GetComponent<AudioSource> ();
		collisionAs = GameObject.Find ("AudioMaster").AddComponent<AudioSource> ();
		splashAS = GameObject.Find ("AudioMaster").AddComponent<AudioSource> ();
		pickUpAs = GameObject.Find ("AudioMaster").AddComponent<AudioSource> ();


		dieAs.clip = dieSound;
		collisionAs.clip = collSound;
		splashAS.clip = splashSound;
		pickUpAs.clip = pickUpSound;
	}
	
	void FixedUpdate() 
	{
		pontuacaoTotal = pontPickUps*2 + pontPlataformas;
		if (platFaltando < 0)
		{
			platFaltando = 10;
		}
	}
	
	void Update () 
	{
		pontuacao.text = "Pontuação\n" + pontuacaoTotal.ToString();	
		platSuperadas.text = "Plataformas\n" + pontPlataformas.ToString();
		pickUpsPT.text = "Itens Coletados\n" + pontPickUps.ToString();
		platFaltandoTXT.text = "Desafio em: \n" + platFaltando.ToString();
		vidasTXT.text = "Vidas: " + lives.ToString ();
	}

	void OnCollisionEnter(Collision other) 
	{
		//dieAs.Play ();

		/*if(other.gameObject.CompareTag("Collision"))
		{
			collisionAs.Play ();
		}
		*/
		if(other.gameObject.CompareTag("Water") && lives != 0)
		{
			splashAS.Play ();
			dieAs.Play ();
			Invoke ("killPlayer", 0.6f);
			lives--;
			Invoke ("respawnPlayer", 1.5f);
		}

		if(other.gameObject.CompareTag("Water") && lives == 0)
		{
			isDead = true;
			gameObject.SetActive (false);
		}

		if (other.gameObject.CompareTag ("PickUp")) {
			pickUpAs.Play ();
			other.gameObject.SetActive (false);
			pontPickUps++;
		}
	}

	public void killPlayer()
	{
		gameObject.SetActive (false);
	}

	public void respawnPlayer()
	{
		transform.position = new Vector3 (respawnPosition.x, respawnPosition.y, respawnPosition.z);
		gameObject.SetActive (true);
	}
}
