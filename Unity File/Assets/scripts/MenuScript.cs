﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
	public void StartGame()
	{
		// "Stage1" is the name of the first scene we created.
		//Application.LoadLevel("Stage1");
		SceneManager.LoadScene("Stage1");

	}

	public void QuitGame()
	{
		// Reload the level
		Application.Quit();
	}
}
