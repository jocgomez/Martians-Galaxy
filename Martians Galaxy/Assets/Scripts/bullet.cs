using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    //private float tiempoHit = 0;
    //private float duracion;
	
	// Update is called once per frame
	void Update () {

        rb.velocity = transform.right * speed;
        //duracion = Time.deltaTime - tiempoHit;
        //if(duracion > 0 && duracion > 10 && duracion <9)
        //{
        //    Destroy(gameObject);
        //    Destroy(impactEffect);
        //}
	}

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(impactEffect);

        //tiempoHit = Time.deltaTime;
    }
}

