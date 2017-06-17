using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Menu : MonoBehaviour {

	public Text scoreText;
	int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play (){
		Application.LoadLevel ("Play"); // load the scene called Play
	}

	public void Pause (){
		if (Time.timeScale == 1) { // if it's 1 game runs
			Time.timeScale = 0; // pause
		} 
		else if (Time.timeScale == 0) { // if it's 0 game pause
			Time.timeScale = 1; // run
		}
	}

	public void Menu(){
		Application.LoadLevel ("Menu"); // load the scene called Menu
	}

	public void Quit(){
		Application.LoadLevel ("Exit"); // load the scene called Exit
	}
}
