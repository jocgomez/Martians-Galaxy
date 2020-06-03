using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidos : MonoBehaviour {

	// Use this for initialization
	public AudioClip salto;
	public AudioSource Audiosource;
	public AudioClip disparo;

	void Start () {

		Audiosource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)){
			Audiosource.PlayOneShot(salto, 1f);
		}

		if (Input.GetKey(KeyCode.Mouse0))
		{
			Audiosource.PlayOneShot(disparo, 0.1f);

		}
		
	}
}
