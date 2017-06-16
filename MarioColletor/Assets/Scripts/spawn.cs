using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {


	//public GameObject killmario;
	public GameObject[] obj_spawn;
	int numObj;
	public float maxPos = 3.5f;
	public float delayTimer = 4f;
	float timer;


	// Use this for initialization
	void Start () {

		timer = delayTimer; //assign the value to the timer


	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime; //decrement the value of the timer
		if (timer <= 0){
			Vector3 mushPos = new Vector3 (Random.Range (-3.5f, 3.5f), transform.position.y, transform.position.z);
			numObj = Random.Range (0,4);

			Instantiate (obj_spawn[numObj], mushPos, transform.rotation);

			timer = delayTimer; //again assign value 1 to respawn again objects
		}
	}
}
