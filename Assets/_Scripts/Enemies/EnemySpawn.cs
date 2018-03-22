using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public float spawnTime = 5.0f;
    public float newSpawnTime;
    int spawnCount = 0;
    int speedMult = 0;
    public GameObject asteroid, enemyShip,enemyTarget;
    private Random rnd;
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
        int j = Mathf.RoundToInt(Random.value * 2);
        GameObject spawned;

        if (j == 1)
            spawned = asteroid;
        else
            spawned = enemyShip;

        Instantiate(spawned);
        spawned.GetComponent<EnemyMove>().speedMult = speedMult;
    }
}
