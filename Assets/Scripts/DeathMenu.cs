﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {
	public Text scoreText;

	//	pause : Time.timeScale = 0.0f; 1.0f;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleEndMenu(int score = 0){
		gameObject.SetActive (true);
		scoreText.text = "" + score;
	}


	public void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}


	public void StartMenu(){
		Application.Quit ();
	}
}
