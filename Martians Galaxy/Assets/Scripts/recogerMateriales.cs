﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogerMateriales : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player personaje = hitInfo.GetComponent<Player>();
        if (personaje != null)
        {
            personaje.obtenerMateriales();
            Destroy(gameObject);
        }

    }
}
