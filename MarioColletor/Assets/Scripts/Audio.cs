using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public static AudioClip mushSound, bonusSound, killSound;
	static AudioSource audioSrc;
	// Use this for initialization
	void Start () {

		mushSound = Resources.Load<AudioClip> ("smb_coin");
		bonusSound = Resources.Load<AudioClip> ("smb_kick");
		killSound = Resources.Load<AudioClip> ("smb_gameover");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string sound){
		switch (sound) {

		case "smb_coin":
			audioSrc.PlayOneShot (mushSound);
			break;
		case "smb_kick":
			audioSrc.PlayOneShot (bonusSound);
			break;
		case "smb_gameover":
			audioSrc.PlayOneShot (killSound);
			break;
		}
	}
}
