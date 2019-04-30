using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2UIController : MonoBehaviour {

	public bool 		 paused;
	public GameObject	 tutorialUI;
	public GameObject    pauseMenuUI;
	public GameObject	 playerInfoUI;
	public GameObject	 player2InfoUI;
	public GameObject	 posJogoUI;
	public PlayerState   playerState1;
	public PlayerState   playerState2;
	public Text   		 pontuacaoTotalFinal;
	public Text   		 numPickUpsFinal;
	public Text   		 numPlataformasFinal;

	public Text   		 pontuacaoTotalFinal2;
	public Text   		 numPickUpsFinal2;
	public Text   		 numPlataformasFinal2;	

	public Text			 vencedor;

	public AudioSource   audioUI;
	public AudioClip     buttonAC;

	void Start()
	{
		playerState1 = GameObject.Find ("Player1").GetComponent<PlayerState> ();
		playerState2 = GameObject.Find ("Player2").GetComponent<PlayerState> ();
		Time.timeScale = 1f;
		posJogoUI.SetActive(false);
		tutorialUI.gameObject.SetActive(true);
		playerInfoUI.gameObject.SetActive(false);
		player2InfoUI.gameObject.SetActive(false);

		audioUI = GameObject.Find ("UI").GetComponent<AudioSource> ();
		audioUI.clip = buttonAC;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			paused = isPaused();	
		}

		if(playerState1.isDead && playerState2.isDead)
		{
			Time.timeScale = 0f;
			pontuacaoTotalFinal.text = playerState1.pontuacao.text;
			numPickUpsFinal.text = playerState1.pickUpsPT.text;
			numPlataformasFinal.text = playerState1.platSuperadas.text;
			if(playerState1.pontuacaoTotal > playerState2.pontuacaoTotal)
				{
					vencedor.text = "Jogador 1 Venceu";
				}else if(playerState1.pontuacaoTotal < playerState2.pontuacaoTotal)
					{
						vencedor.text = "Jogador 2 Venceu";	
					}else if(playerState1.pontuacaoTotal == playerState2.pontuacaoTotal)
					{
						vencedor.text = "Empate";
					}

			playerInfoUI.gameObject.SetActive(false);
			player2InfoUI.gameObject.SetActive(false);
			posJogoUI.gameObject.SetActive(true);
		}

		if(playerState1.isDead)
		{
			pontuacaoTotalFinal.text = playerState1.pontuacao.text;
			numPickUpsFinal.text = playerState1.pickUpsPT.text;
			numPlataformasFinal.text = playerState1.platSuperadas.text;
		}

		if(playerState2.isDead)
		{
			pontuacaoTotalFinal2.text = playerState2.pontuacao.text;
			numPickUpsFinal2.text = playerState2.pickUpsPT.text;
			numPlataformasFinal2.text = playerState2.platSuperadas.text;
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
		SceneManager.LoadScene("2Players");
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
		player2InfoUI.gameObject.SetActive(true);
	}

	public bool isPaused()
	{
		if(Time.timeScale == 0f)
		{
			pauseMenuUI.gameObject.SetActive(false);
			playerInfoUI.gameObject.SetActive(true);
			player2InfoUI.gameObject.SetActive(true);
			Time.timeScale = 1f;
			return(false);
		}else
		{
			Time.timeScale = 0f;
			pauseMenuUI.gameObject.SetActive (true);
			playerInfoUI.gameObject.SetActive(false);
			player2InfoUI.gameObject.SetActive(false);
			return(true);
		}
	}

}
