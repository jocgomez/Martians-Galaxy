using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidos : MonoBehaviour {

	// Use this for initialization
	public AudioClip salto;
	public AudioSource AudiosourceEfectos;
	public AudioClip disparo;
	public AudioSource AudiosourceAmbiente;
	public AudioClip respiracion;
	public AudioClip ambiente;
	public AudioClip audioPausa;
	public AudioSource AudiosourcePausa;
	bool conSonido = true;

	void Start () {

		AudiosourceEfectos = GetComponent<AudioSource>();
		AudiosourceAmbiente = GetComponent<AudioSource>();
		AudiosourcePausa = GetComponent<AudioSource>();
		AudiosourceAmbiente.PlayOneShot(respiracion, 0.2f);
		AudiosourceAmbiente.PlayOneShot(ambiente, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)){
			AudiosourceEfectos.PlayOneShot(salto, 1f);
		}

		if (Input.GetKey(KeyCode.Mouse0) && Time.timeScale == 1)
		{
			AudiosourceEfectos.PlayOneShot(disparo, 0.1f);

		}

		if (conSonido)
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				pausarSonidosAmbiente();

			}

			
		}
		else
		{
			
				pausarSonidos();

			if (Input.GetKeyDown(KeyCode.P))
			{
				pausarSinSonidos();
			}
			
		}

	}

	void pausarSonidosAmbiente()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			AudiosourceAmbiente.Stop();
			AudiosourcePausa.PlayOneShot(audioPausa, 0.8f);

		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
			AudiosourcePausa.Stop();
			AudiosourceAmbiente.PlayOneShot(respiracion, 0.2f);
			AudiosourceAmbiente.PlayOneShot(ambiente, 0.5f);


		}
	}

	void pausarSinSonidos()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			AudiosourceAmbiente.Stop();
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
			AudiosourcePausa.Stop();
		}

	}

	public void pausarSonidos()
	{
		AudiosourcePausa.Stop();
		AudiosourceAmbiente.Stop();
	}

	public void reanudarSonidosAmbiente()
	{
		
			Time.timeScale = 1;
			AudiosourcePausa.Stop();
			AudiosourceAmbiente.PlayOneShot(respiracion, 0.2f);
			AudiosourceAmbiente.PlayOneShot(ambiente, 0.5f);

	}


	public void verificarSonidos()
	{
		if (conSonido)
		{
			conSonido = false;
		}
		else
		{
			conSonido = true;
			AudiosourcePausa.PlayOneShot(audioPausa, 0.8f);
			
		}
	}

	public void verificarSonidosMuerte(bool conSonido)
	{
		if (conSonido)
		{
			conSonido = false;
		}
		else
		{
			conSonido = true;
			AudiosourceAmbiente.Stop();

		}
	}


}
