using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public float spawnTime = 5.0f;
    public float newSpawnTime;
    int spawnCount, speedMult, currentLoc, prevLoc, asteroidSpawn;
    public GameObject asteroid, enemyShip,enemyTarget;
    private Random rnd;
    public Vector3 spawnLoc;
	// Use this for initialization
	void Start () {
        Instantiate(enemyTarget, new Vector3(0.0f, 0.0f, -20.0f),Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0)
        {
            spawnEnemy();
            spawnTime = 2 + Random.value;
            spawnCount++;
            //Debug.Log("New Spawn Time: "+spawnTime+"s");
            speedMult = Mathf.FloorToInt(spawnCount / 10);
        }
	}

    void spawnEnemy()
    {
        
        for(int j = 0; j < 10; j++)
        {
            currentLoc = Mathf.RoundToInt(Random.value * 3);
            if (currentLoc != prevLoc)
                break;
        }

        prevLoc = currentLoc;

        if (currentLoc == 0)
            spawnLoc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(3.0f, 10.0f), 1050);
        else if (currentLoc == 1)
            spawnLoc = new Vector3(Random.Range(-10.0f, -3.0f), Random.Range(2.0f, 10.0f), 1050);
        else
            spawnLoc = new Vector3(Random.Range(3.0f, 10.0f), Random.Range(2.0f, 10.0f), 1050);
        //Debug.Log("Speed: "+speedMult);

        Instantiate(enemyShip, spawnLoc, Quaternion.identity);

        enemyShip.GetComponent<EnemyMove>().speedMult = speedMult;

        if (asteroidSpawn > Random.Range(0,6))
        {
            for (int j = 0; j < 10; j++)
            {
                currentLoc = Mathf.RoundToInt(Random.value * 3);
                if (currentLoc != prevLoc)
                    break;
            }

            prevLoc = currentLoc;

            if (currentLoc == 0)
                spawnLoc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(3.0f, 10.0f), 100);
            else if (currentLoc == 1)
                spawnLoc = new Vector3(Random.Range(-10.0f, -3.0f), Random.Range(2.0f, 10.0f), 100);
            else
                spawnLoc = new Vector3(Random.Range(3.0f, 10.0f), Random.Range(2.0f, 10.0f), 100);

            Instantiate(asteroid, spawnLoc, Quaternion.identity);
            asteroidSpawn = 0;
        }

        else
            asteroidSpawn++;

      //  Instantiate(asteroid);
    }
}