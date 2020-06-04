using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class InicioPartida : MonoBehaviour {

	public GameObject inicial;
	public GameObject objetivos;
	void Start()
	{
		inicial.gameObject.SetActive(true);
		objetivos.gameObject.SetActive(false);

	}

	public void mostrarObjetivos()
	{
		objetivos.gameObject.SetActive(true);
		inicial.gameObject.SetActive(false);
	}

	public void botonIniciarV4()
	{
		SceneManager.LoadScene("AnimV4");
	}

	public void botonInicirV5()
	{
		SceneManager.LoadScene("AnimV5");
	}

	public void salir()
	{
		Application.Quit();
		Debug.Log("Se ha cerrado");
	}

	public void pantallaInicial()
	{
		SceneManager.LoadScene("PantallaInicio");
	}
}
