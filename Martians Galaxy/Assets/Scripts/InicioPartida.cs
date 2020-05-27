using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioPartida : MonoBehaviour {

	


	public void botonIniciar()
	{
		SceneManager.LoadScene("AnimV3");
	}

	public void salir()
	{
		Application.Quit();
		Debug.Log("Se ha cerrado");
	}
}
