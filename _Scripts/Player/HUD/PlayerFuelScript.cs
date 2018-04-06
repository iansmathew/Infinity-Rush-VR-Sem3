using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFuelScript : MonoBehaviour {

    [Header("Fuel Properties")]
    [SerializeField]
    private float maxFuel = 100.0f;
    private float currFuel;

    [SerializeField]
    private GameObject healthBar;
    [SerializeField]
    private float healthBarChangeSpeed = 10.0f;
    private float initialLocalXScale;

    [SerializeField]
    private float fuelDepletionAmount = 1.0f;
    [SerializeField]
    private float fuelDepletionSpeedInSeconds = 0.2f;
    private float lastFuelReduced;

    [Header("Score Properties")]
    [SerializeField]
    private Text scoreText;
    private int currScore = 0;

    [Header("Danger HUD Element Properties")]
    [SerializeField]
    private GameObject dangerText;
    [SerializeField]
    private float flashSpeed = 0.2f;
    private int maxFlashDangerCount = 3;


    //Bool checks
    private bool decreaseFuel = false;

    private void Start()
    {
        currFuel = maxFuel;
        decreaseFuel = true;

        lastFuelReduced = Time.time;

        initialLocalXScale = healthBar.transform.localScale.x;
    }

    private void Update()
    {
        if (currFuel <= 0)
        {
            HUDScript.Instance.ShowEndGameScreen();
        }

        if (decreaseFuel && Time.time > lastFuelReduced + fuelDepletionSpeedInSeconds)
        {
            currFuel -= fuelDepletionAmount;
            lastFuelReduced = Time.time;

            UpdateSlider();
        }
    }

    public void DamagePlayer(float dmgAmt)
    {
        currFuel -= dmgAmt;
        StartCoroutine(ShowDangerText());
    }

    public void AddFuel(float amt)
    {
        if (currFuel + amt > 100)
            currFuel = 100;
        else 
            currFuel += amt;
    }

    public void AddScore(int _score)
    {
        currScore += _score;
        scoreText.text = "Score: " + currScore.ToString();
    }

    private void UpdateSlider()
    {
        float mappedFuel = ReMap(currFuel, 0, maxFuel, 0, initialLocalXScale);       
        float scaleX = Mathf.MoveTowards(healthBar.transform.localScale.x, mappedFuel, Time.deltaTime * healthBarChangeSpeed);
        healthBar.transform.localScale = new Vector3(scaleX, healthBar.transform.localScale.y, 0);
    }

    private float ReMap(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }

    IEnumerator ShowDangerText()
    {
        int flashCounter = 0;
        while(flashCounter < maxFlashDangerCount)
        {
            flashCounter++;
            dangerText.SetActive(true);

            yield return new WaitForSeconds(flashSpeed);

            dangerText.SetActive(false);
        }

        yield break;
    }
    

}
