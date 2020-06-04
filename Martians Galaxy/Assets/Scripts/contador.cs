using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour {


	
	public Text valor;
	Player personaje;
	// Use this for initialization
	

	public void mostrarMuertes(int muertes)
	{
		valor.text = "Enemigos eliminados: " + muertes.ToString();
	}
}
