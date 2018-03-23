using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerScript : MonoBehaviour{

    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject instrucPanel;


    void Start()
    {
    	
    }

    void Update()
    {
	
    }

    public void PlayButton()
    {
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

}
