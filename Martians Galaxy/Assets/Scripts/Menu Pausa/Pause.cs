using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {


	public GameObject pausaPrincipal;
	public GameObject pausaControles;
	public GameObject pausaObjetivos;
	bool mostrar;

	// Use this for initialization
	void Start () {

		pausaPrincipal.gameObject.SetActive(false);
		pausaControles.gameObject.SetActive(false);
		pausaObjetivos.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.P))
		{
			pauseGame();
			
		}

		
	}

	public void pauseGame()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			pausaPrincipal.gameObject.SetActive(true);
		}
		else
		{
			Time.timeScale = 1;
			pausaPrincipal.gameObject.SetActive(false);

		}
	}

	public void reanudar()
	{
		pausaPrincipal.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
}
