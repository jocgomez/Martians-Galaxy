using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealDamage : MonoBehaviour {

    public int damage = 20;

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
            personaje.TakeDamage(damage);
        }


        //tiempoHit = Time.deltaTime;
    }
}
