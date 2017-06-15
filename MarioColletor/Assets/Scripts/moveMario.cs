using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMario : MonoBehaviour {

	public float speed;


	Vector3 position;
	// Use this for initialization
	void Start () {
		position = transform.position; //assign current position of the car to the position Vector3 variable

	}
	
	// Update is called once per frame
	void Update () {
		//increase speed by pressing arrow key

		position.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime; //increment value position
		position.x = Mathf.Clamp (position.x, -3.46f, 3.46f); 

		transform.position = position; 
	}

	void OnCollisionEnter2D(Collision2D colision){
		if (colision.gameObject.tag == "Enemy") {
			Destroy (gameObject);
		}
	}

}
