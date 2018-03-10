using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
    public GameObject BackgroundForPause;
	public GameObject MainUI;


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (GameIsPaused) {
				Resume ();
			} else 
			{
				Pause ();
			}
		}
	}


public void Resume()
{
        BackgroundForPause.SetActive(false);
		pauseMenuUI.SetActive (false);
		MainUI.SetActive (true);
		Time.timeScale = 1.0f;
		GameIsPaused = false;;

}
	void Pause()
	{
        BackgroundForPause.SetActive(true);
        pauseMenuUI.SetActive (true);
		MainUI.SetActive (false);
		Time.timeScale = 0.0f;
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void Quit()
	{
		Debug.Log ("Quit!");
		Application.Quit ();
	}
}