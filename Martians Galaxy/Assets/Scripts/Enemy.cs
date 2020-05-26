using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy : MonoBehaviour {

	public int health = 100;
	public GameObject deathEffect;
    public GameObject vida;
    public float probabilidadVida = 20f;
    public GameObject materiales;    
    public float probabilidadMateriales = 10f;
    public AIPath aiPath;

    private float probV;
    private float probM;

    public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
        probV = Random.Range(0f, 100f);
        probM = Random.Range(0f, 100f);

        if (probV <= probabilidadVida)
        {
            Instantiate(vida, transform.position, Quaternion.identity);
        }

        if (probM <= probabilidadMateriales)
        {
            Instantiate(materiales, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
        
	}

    public void Update()
    {
    if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }else if(aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

}
