using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMushroom : MonoBehaviour {


	public GameObject mushrooms;
	public float maxPos = 3.5f;
	public float delayTimer = 1.5f;
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

			Instantiate (mushrooms, mushPos, transform.rotation);

			timer = delayTimer; //again assign value 1 to respawn again objects
		}
	}
}
