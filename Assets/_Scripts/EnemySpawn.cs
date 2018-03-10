using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public float spawnTime = 5.0f;
    public float newSpawnTime;
    int spawnCount = 0;
    int speedMult = 0;
    public GameObject asteroid, enemyShip;
    private Random rnd;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0)
        {
            spawnEnemy();
            spawnTime = 2 + Random.value;
            spawnCount++;
            Debug.Log("New Spawn Time: "+spawnTime+"s");
            speedMult = Mathf.FloorToInt(spawnCount / 10);
        }
	}

    void spawnEnemy()
    {
        Vector3 position;
        int i = Mathf.RoundToInt(Random.value * 3);
        int j = Mathf.RoundToInt(Random.value * 2);
        GameObject spawned;

        if (j == 1)
            spawned = asteroid;
        else
            spawned = enemyShip;

        if (i == 0)
            position = new Vector3(Random.Range(-10.0f, 10.0f), 50, Random.Range(-10.0f, -2.0f));
        else if (i == 1)
            position = new Vector3(Random.Range(-10.0f, -3.0f), 50, Random.Range(-10.0f, 0.0f));
        else
            position = new Vector3(Random.Range(3.0f, 10.0f), 50, Random.Range(-10.0f, 0.0f));

        Instantiate(spawned,transform.parent,true);
        spawned.GetComponent<EnemyMove>().speedMult = speedMult;
    }
}
