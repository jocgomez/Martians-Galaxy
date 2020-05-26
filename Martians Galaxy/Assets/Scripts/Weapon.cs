using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPrefab;
    float secondsCounter=0;
   float secondsToCount=0.3f;

	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {

                  secondsCounter += Time.deltaTime;
            if (secondsCounter >= secondsToCount)
            {
                secondsCounter = 0;
                Shoot();
            }
        }
		
	}

    void Shoot()
    {
        // Shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
