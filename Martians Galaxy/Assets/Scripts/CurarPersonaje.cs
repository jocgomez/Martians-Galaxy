using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurarPersonaje : MonoBehaviour {

    public int Curar = 15;

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
            personaje.TakeHeal(Curar);
            Destroy(gameObject);
        }
        
    }

}

