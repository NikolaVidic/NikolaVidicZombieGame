using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FieldController : MonoBehaviour {

	public AudioSource zombieDying; 
	public AudioSource loss;
	public Text livesDisplay; 
	private int lives;
	public Text rules;


	// Use this for initialization
	void Start () {
		lives = 5;
		rules.text = "Kill 10 zombies to win, if 5 cross the end then you lose"; 
	}
	
	// Update is called once per frame
	void Update () {
		SetText ();

		if (lives == 0) {
			rules.text = "You lose";
			loss.Play ();
			Application.Quit ();
		}
			
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Zombie")) {
			Destroy (other.gameObject); 
			zombieDying.Play(); 
			lives--;
		}

		if (other.gameObject.CompareTag ("Projectile")) {
			Destroy (other.gameObject);
		}
	}

	void SetText () {
		livesDisplay.text = "Lives: " + lives.ToString ();  
	}
}
