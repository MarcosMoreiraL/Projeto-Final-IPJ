using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	public bool 		 paused;
	public GameObject	 tutorialUI;
	public GameObject    pauseMenuUI;
	public GameObject	 playerInfoUI;
	public GameObject	 posJogoUI;
	public PlayerState   playerState1;
	public Text   		 pontuacaoTotalFinal;
	public Text   		 numPickUpsFinal;
	public Text   		 numPlataformasFinal;

	public AudioSource   audioUI;
	public AudioClip     buttonAC;

	void Start()
	{
		playerState1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();;
		Time.timeScale = 1f;
		posJogoUI.SetActive(false);
		tutorialUI.gameObject.SetActive(true);
		playerInfoUI.gameObject.SetActive(false);

		audioUI = GameObject.Find ("UI").GetComponent<AudioSource> ();
		audioUI.clip = buttonAC;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			paused = isPaused();	
		}

		if(playerState1.isDead)
		{
			Time.timeScale = 0f;
			pontuacaoTotalFinal.text = playerState1.pontuacao.text;
			numPickUpsFinal.text = playerState1.pickUpsPT.text;
			numPlataformasFinal.text = playerState1.platSuperadas.text;
			playerInfoUI.gameObject.SetActive(false);
			posJogoUI.gameObject.SetActive(true);
		}
	}

	public void VoltarAoMenu()
	{
		audioUI.Play ();
		SceneManager.LoadScene("Menu");
	}

	public void playAgain()
	{
		audioUI.Play ();
		SceneManager.LoadScene("Game");
	}

	public void buttonPause()
	{
		audioUI.Play ();
		paused = isPaused();
	}
	
	public void tutorialOut()
	{
		audioUI.Play ();
		tutorialUI.gameObject.SetActive(false);
		playerInfoUI.gameObject.SetActive(true);
	}

	public bool isPaused()
	{
		if(Time.timeScale == 0f)
		{
			pauseMenuUI.gameObject.SetActive(false);
			playerInfoUI.gameObject.SetActive(true);
			Time.timeScale = 1f;
			return(false);
		}else
		{
			Time.timeScale = 0f;
			pauseMenuUI.gameObject.SetActive (true);
			playerInfoUI.gameObject.SetActive(false);
			return(true);
		}
	}
}
