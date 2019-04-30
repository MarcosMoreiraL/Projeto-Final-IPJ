using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Menu2 : MonoBehaviour {

	public Text      titulo;

	public InputField altura;
	public InputField largura;

	public Slider volumeSlider;
	public AudioMixer mixer;

	public bool     menuPrincipal,menuOp,menuSelect;

	public bool fullScreen = true;
	public int alturaTela = 768;
	public int larguraTela = 1366;

	public GameObject menuPrincipalUI;
	public GameObject menuOpUI;
	public GameObject menuSelectUI;

	public AudioSource   audioUI;
	public AudioSource 	 menuSong;

	public AudioClip     menuSound;
	public AudioClip     buttonAC;

	// Use this for initialization
	void Awake(){}

	void Start () {
		menuPrincipal = true;
		menuOp = false;
		menuSelect = false;

		menuSong = GameObject.Find ("UI").GetComponent<AudioSource> ();
		menuSong.clip = menuSound;

		audioUI = GameObject.Find ("btAudioControl").GetComponent<AudioSource> ();

		audioUI.clip = buttonAC;


		menuSong.Play ();
	}

	// Update is called once per frame
	void Update () 
	{
		menuPrincipalOn();
		menuOpOn();
		menuSelectOn();

	}
		
	public void volumeConfig(float sliderValue)
	{
		mixer.SetFloat ("MusicVol", Mathf.Log10 (sliderValue) * 20);
	}

	public void CarregarMenuPrincipal()
	{
		audioUI.Play ();
		menuPrincipal = true;
		menuOp = false;
		menuSelect = false;
	}

	public void CarregarLvlSelect()
	{
		audioUI.Play ();
		menuPrincipal = false;
		menuOp = false;
		menuSelect = true;
	}

	public void CarregarMenuOp()
	{
		audioUI.Play ();
		menuPrincipal = false;
		menuOp = true;
		menuSelect = false;
	}

	public void CarregarFase1Player()
	{
		audioUI.Play ();
		SceneManager.LoadScene ("Game");
	}

	public void CarregarFase2Player()
	{
		audioUI.Play ();
		SceneManager.LoadScene ("2Players");
	}

	public void QuitGame()
	{
		audioUI.Play ();
		Application.Quit();
	}

	void menuPrincipalOn()
	{
		if (menuPrincipal == true)
		{
			menuPrincipalUI.gameObject.SetActive(true);
			titulo.text = "Menu Principal";
		}else
		{
			menuPrincipalUI.gameObject.SetActive(false);
		}
	}

	void menuSelectOn()
	{
		if(menuSelect == true)
		{
			menuSelectUI.gameObject.SetActive(true);
			titulo.text = "Selecione o Modo de Jogo";
		}else
		{
			menuSelectUI.gameObject.SetActive(false);
		}
	}

	void menuOpOn()
    {
    	if(menuOp == true)
    	{
			menuOpUI.gameObject.SetActive(true);
			titulo.text = "Configurações";
    	}else
    	{
			menuOpUI.gameObject.SetActive(false);
    	}
    }

	public void Qualidade1()
	{
		audioUI.Play ();
		QualitySettings.SetQualityLevel(0);
	}
	public void Qualidade2()
	{
		audioUI.Play ();
		QualitySettings.SetQualityLevel(2);
	}
	public void Qualidade3()
	{
		audioUI.Play ();
		QualitySettings.SetQualityLevel(4);
	}

	public void TelaCheia()
	{
		audioUI.Play ();
		fullScreen = !fullScreen;
		Screen.SetResolution(Screen.width, Screen.height, fullScreen);
	}
		
	public void Resolucao()
	{
		audioUI.Play ();
		alturaTela = int.Parse(altura.text);
		larguraTela = int.Parse (largura.text);
		
		Screen.SetResolution (larguraTela, alturaTela, fullScreen);
	}

	public void VoltarAoMenu()
	{
		audioUI.Play ();
		SceneManager.LoadScene("Menu");
	}
}
