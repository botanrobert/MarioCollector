using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveMario : MonoBehaviour {

	public float speed;
	private int count;
	public Text countText;

	Vector3 position;

	// Use this for initialization
	void Start () {
		count = 0; //set the score to 0
		SetCountText (); //function that increase the score
		position = transform.position; //assign current position of the car to the position Vector3 variable

	}
	
	// Update is called once per frame
	void Update () {
		//increase speed by pressing arrow key

		position.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime; //increment value position
		//position.x = Input.acceleration.x * speed * Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -3.46f, 3.46f); 

		transform.position = position; 
	}

	void OnCollisionEnter2D(Collision2D colision)
	{
		if (colision.gameObject.tag == "Enemy") { // check the gameobject with tag Enemy
			Destroy (gameObject); // destroy the object with that tag
		} 

		if (colision.gameObject.tag == "mushroom") // check the gameobject with tag mushroom
		{
			count = count + 1; // increase the score with 1
			SetCountText (); // call function
			Destroy (colision.gameObject); // destroy the mushroom after colision
		}

		if (colision.gameObject.tag == "star") // check the gameobject with tag star
		{
			count = count + 5; // increase with 5 
			SetCountText (); // call function
			Destroy (colision.gameObject); // destroy the star after collision
		}
	}

	void SetCountText(){
		countText.text = "Score " + count.ToString (); // function that counts the score
	}
}
