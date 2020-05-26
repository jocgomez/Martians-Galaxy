using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;
    public mostrarMateriales barraMateriales;
    private int materiales;

    // Start is called before the first frame update
    void Start()
    {
        materiales = 0;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (currentHealth==0)
		{
            Time.timeScale = 0;
		}
    }

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

    public void TakeHeal(int heal)
    {
        if(currentHealth != maxHealth)
        {
            currentHealth += heal;
            healthBar.SetHealth(currentHealth);
        }
        
    }

    public void obtenerMateriales()
    {
        materiales += 1;
        barraMateriales.mostrarM(materiales);
    }
}
