using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

    [Header("HUD Image Elements")]
    [SerializeField]
    private GameObject conditionPanel;

    //Player Fuel Script
    PlayerFuelScript playerFuelScript;

    //Instance properties
    public static HUDScript Instance { get; private set; }

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        //Setting default values
        playerFuelScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerFuelScript>();

        conditionPanel.SetActive(false);
    }

    public void ShowEndGameScreen()
    {
        conditionPanel.SetActive(true);
    }

    public void UpdateScore(int _score)
    {
        playerFuelScript.AddScore(_score);
    }

    public void UpdatePlayerHealth(float dmgAmount)
    {
        playerFuelScript.DamagePlayer(dmgAmount);
    }
}
