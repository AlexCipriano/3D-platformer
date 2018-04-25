using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	public static bool paused;
	public GameObject pauseMenu;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (paused) {
				Resume ();
			} else 
			{
				Pause();
			}
		}

		
	}


	public void Resume()
	{
		pauseMenu.SetActive (false);
		Time.timeScale = 1f;
		paused = false;
	}

	void Pause ()
	{
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
		paused = true;
	}

	public void Quit() 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

}
