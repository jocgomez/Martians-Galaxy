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
    private int contadorMuertes;
    public GameObject menuMuerte;
    public AudioSource ASmuerteEnemigo;
    public AudioClip audioMuerteEnemigo;
   
    public GameObject finJuego;
    public AudioClip sonidoMuerteJefe;
    public AudioClip nivelCompletado;
    public AudioSource ASsonidoMuerteJefe;
    public AudioSource ASsonidoMuertePersonaje;
    public GameObject deathEffect;
    sonidos pausaSonidosFinJuego;
   
    public AudioClip muertePersonaje;

    // Start is called before the first frame update
    void Start()
    {
        contadorMuertes = 0;
        materiales = 0;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
        Time.timeScale = 1;
        menuMuerte.gameObject.SetActive(false);
        ASmuerteEnemigo = GetComponent<AudioSource>();
        finJuego.gameObject.SetActive(false);
        ASsonidoMuerteJefe = GetComponent<AudioSource>();
        pausaSonidosFinJuego = GetComponent<sonidos>();
        
        ASsonidoMuertePersonaje = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
		if (currentHealth<=0)
		{
            
            Time.timeScale = 0;
            
            menuMuerte.gameObject.SetActive(true);
            



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

    public void contadorMuertesEnemigos()
    {
        contadorMuertes+= 1;
       
        ASmuerteEnemigo.PlayOneShot(audioMuerteEnemigo, 1f);
        Debug.Log(contadorMuertes);
    }

    public void finalJuego()
    {
        finJuego.gameObject.SetActive(true);
        pausaSonidosFinJuego.pausarSonidos();
        ASsonidoMuerteJefe.PlayOneShot(sonidoMuerteJefe, 1f);
        ASsonidoMuerteJefe.PlayOneShot(nivelCompletado, 0.5f);
        Time.timeScale = 0;
    }

    
}
