using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveMario : MonoBehaviour {

	public float speed;
	private int count;
	public Text countText;
	public UI_Menu ui;

	public AudioSource mushroom;
	public AudioSource bonus;

	bool platformAndroid = false;
	Vector3 position;

	Rigidbody2D rb;

	void Awake(){



		rb = GetComponent<Rigidbody2D> ();

		#if UNITY_ANDROID // is true only when runs android
			platformAndroid = true;

		#else 
			platformAndroid = false;
		#endif


	}

	// Use this for initialization
	void Start () {
		count = 0; //set the score to 0
		SetCountText (); //function that increase the score
		position = transform.position; //assign current position of the car to the position Vector3 variable
		
		if (platformAndroid == true) {
		
			Debug.Log ("Android");
		} else {
			Debug.Log ("Windows");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (platformAndroid == true) { //when the game runs on android
			Accelerometer();
		} 
		else {
			position.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime; //increment value position
			//position.x = Input.acceleration.x * speed * Time.deltaTime;
			position.x = Mathf.Clamp (position.x, -3.4f, 3.4f); 

			transform.position = position; 
		}
	}

	void Accelerometer(){

		float x = Input.acceleration.x; // stocarea valorilor de pe axa x

		if (x < -0.1f) {
			MoveLeft ();
		} 
		else if (x > 0.1f) {
			MoveRight ();
		} 
		else {
			setVelocityZero ();
		}
	}


	public void MoveLeft(){
		rb.velocity = new Vector2 (-speed, 0);
	}

	public void MoveRight(){
		rb.velocity = new Vector2 (speed, 0);
	}

	public void setVelocityZero(){
		rb.velocity = Vector2.zero;
	}
	void OnCollisionEnter2D(Collision2D colision)
	{
		if (colision.gameObject.tag == "Enemy") { // check the gameobject with tag Enemy
			Destroy (gameObject); // destroy the object with that tag
			ui.gameOverActivated(); // call the function from ui_menu

		} 

		if (colision.gameObject.tag == "mushroom") // check the gameobject with tag mushroom
		{
			mushroom.Play ();
			count = count + 1; // increase the score with 1
			SetCountText (); // call function
			Destroy (colision.gameObject); // destroy the mushroom after colision

		}

		if (colision.gameObject.tag == "star") // check the gameobject with tag star
		{
			bonus.Play ();
			count = count + 5; // increase with 5 
			SetCountText (); // call function
			Destroy (colision.gameObject); // destroy the star after collision
		}
	}

	void SetCountText(){
		countText.text = "Score " + count.ToString (); // function that counts the score
	}


}
