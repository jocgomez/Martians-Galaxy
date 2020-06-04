using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostrarMateriales : MonoBehaviour {

    public GameObject pasarAlJefe;
	// Use this for initialization
	void Start () {
        pasarAlJefe.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mostrarM(int materiales)
    {
        switch(materiales)
        {
            case 1:
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case 2:
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 3:
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 4:
                gameObject.transform.GetChild(3).gameObject.SetActive(true);
                break;
            case 5:
                gameObject.transform.GetChild(4).gameObject.SetActive(true);
                pasarAlJefe.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }
        
    }
}
