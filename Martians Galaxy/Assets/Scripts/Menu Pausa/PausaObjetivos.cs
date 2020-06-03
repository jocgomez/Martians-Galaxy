using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaObjetivos : MonoBehaviour {

	// Use this for initialization
	public GameObject pausaPrincipal;
	
	public GameObject pausaobjetivos;


	public void pausaObjetivos()
	{
		pausaobjetivos.gameObject.SetActive(true);
		
		pausaPrincipal.gameObject.SetActive(false);
	}
	public void volverObjetivos()
	{
		pausaobjetivos.gameObject.SetActive(false);
		
		pausaPrincipal.gameObject.SetActive(true);
	}


}
