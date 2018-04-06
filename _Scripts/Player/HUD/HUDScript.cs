using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

    [Header("HUD Image Elements")]
    [SerializeField]
    private GameObject conditionPanel;
    [SerializeField] private GameObject menuPanel;

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

    public void AddPlayerFuel(float amount)
    {
        playerFuelScript.AddFuel(amount);
    }

    public void QuitButton()
    {
        playerFuelScript.AddFuel(100);
        conditionPanel.SetActive(false);
        menuPanel.SetActive(true);
        GameManagerScript.Instance.StopGame();
    }

    public void RestartButton()
    {
        conditionPanel.SetActive(false);
        playerFuelScript.AddFuel(100);
    }

}
