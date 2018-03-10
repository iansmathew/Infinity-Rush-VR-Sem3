using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public void PlayGame()																				//Loads the Game Screen
	{
		SceneManager.LoadScene ("GameScene");
	}

	//Enable Settings Menu																				//Activate The Setting Menu
	//Public void Settings()
	//{
	//	Disable Menu_Panel
	//Enable Settings_Panel
	//}

	//Enable High Score Menu																			//Activate The High Score Menu
	//Public void HighScore()
	//{
	//	Disable Menu_Panel
	//Enable Settings_Panel
	//}


	public void Quit()																						//Quits the Game
	{
		Debug.Log ("Quit!");
		Application.Quit ();
	}





}
