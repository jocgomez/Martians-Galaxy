using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour {

    public GameObject[] enemies;
    public Transform[] spawnPoint;

    private int randomEnemy;
    private int randomPosition;

    public float startTimeBtwSpawn;
    private float timeBtwSpawns;

	// Use this for initialization
	void Start () {
        timeBtwSpawns = startTimeBtwSpawn;
	}
	
	// Update is called once per frame
	void Update () {

        if(timeBtwSpawns <= 0)
        {
            randomEnemy = Random.Range(0, enemies.Length);
            randomPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(enemies[randomEnemy], spawnPoint[randomPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
		
	}
}
