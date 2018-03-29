﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerScript : MonoBehaviour{

    [Header("UI Objects")]
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject instrucPanel;

    [Header("Sound")]
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip buttonHoverSound;
    [SerializeField]
    private AudioClip playButtonSelect;


    void Start()
    {
    	
    }

    void Update()
    {
	
    }

    public void PlayButton()
    {
        audioSource.clip = playButtonSelect;
        audioSource.Play();

        GameManagerScript.Instance.StartGame();
        menuPanel.gameObject.SetActive(false);
    }

    public void InstrucButton()
    {
        menuPanel.gameObject.SetActive(false);
        instrucPanel.gameObject.SetActive(true);

    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        menuPanel.gameObject.SetActive(true);
        instrucPanel.gameObject.SetActive(false);
    }

    public void PlayHoverSound()
    {
        audioSource.clip = buttonHoverSound;
        audioSource.Play();
    }

}
