using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaControles : MonoBehaviour {

	// Use this for initialization

	public GameObject pausacontroles;
	public GameObject pausaPrincipal;

	public void pausaControles()
	{
		pausacontroles.gameObject.SetActive(true);
		pausaPrincipal.gameObject.SetActive(false);

	}

	public void volverControles()
	{
		pausacontroles.gameObject.SetActive(false);
		pausaPrincipal.gameObject.SetActive(true);
	}
}
