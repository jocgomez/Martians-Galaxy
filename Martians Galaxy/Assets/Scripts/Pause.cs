using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {


	public GameObject visibility;
	bool mostrar;

	// Use this for initialization
	void Start () {

		visibility.gameObject.SetActive(false);
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
			visibility.gameObject.SetActive(true);
		}
		else
		{
			Time.timeScale = 1;
			visibility.gameObject.SetActive(false);

		}
	}
}
