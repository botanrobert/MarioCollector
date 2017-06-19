using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject[] obj_spawn; // array objects spawned
	int numObj; //number of objects spawned
	public float maxPos = 3.4f; // max position spawn
	public float delayTimer = 3f; // objects spawn after 3 sec
	float timer;


	// Use this for initialization
	void Start () {

		timer = delayTimer; //assign the value to the timer


	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime; //decrement the value of the timer
		if (timer <= 0){
			Vector3 mushPos = new Vector3 (Random.Range (-3.4f, 3.4f), transform.position.y, transform.position.z);
			numObj = Random.Range (0,4); // number off objects

			Instantiate (obj_spawn[numObj], mushPos, transform.rotation); // instantiate the num off objects, in the range

			timer = delayTimer; //again assign value 1 to respawn again objects
		}
	}
}
