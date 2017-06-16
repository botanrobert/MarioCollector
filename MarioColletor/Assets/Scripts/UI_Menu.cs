using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause(){
		if (Time.timeScale == 1) { // if it's 1 game runs
			Time.timeScale = 0; // pause
		} 
		else if (Time.timeScale == 0) { // if it's 0 game pause
			Time.timeScale = 1; // run
		}
	}
}
