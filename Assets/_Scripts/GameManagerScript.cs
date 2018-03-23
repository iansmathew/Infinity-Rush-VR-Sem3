using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    [Header("Managers")]
    [SerializeField]
    private GameObject enemyManager;
    [SerializeField]
    private GameObject player;

    //Instance
    public static GameManagerScript Instance { get; private set; }

    private void Start()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
        }
    }

    public void StartGame()
    {
        enemyManager.GetComponent<EnemySpawn>().enabled = true;
        player.GetComponent<PlayerFuelScript>().enabled = true;
    }
}
