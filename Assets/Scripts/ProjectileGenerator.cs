using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileGenerator : MonoBehaviour {

	public Rigidbody2D projectile;
	private int counter; 

	public Text scoreDisplay; 
	public AudioSource win;
	public CapsuleCollider2D hit;


	public int score;

	// Use this for initialization
	void Start () {
		Rigidbody2D projectileClone = (Rigidbody2D)Instantiate (projectile, transform.position, transform.rotation);
		counter = 1;
	}

	// Update is called once per frame
	void Update () {
		CheckProjectile ();
		TextUpdate ();

		if (counter == 0) {
			Rigidbody2D projectileClone = (Rigidbody2D)Instantiate (projectile, transform.position, transform.rotation);
			counter = 1;
		}
			

		if (score == 10) {
			scoreDisplay.text = "You win!";
			win.Play ();
			Application.Quit(); 
		}
			
	}

	void CheckProjectile () {
		projectile.GetComponent<Rigidbody2D> (); 
		if (projectile == null) {
			counter = 0;
		}
	}

	void TextUpdate () {
		scoreDisplay.text = "Score: " + score.ToString ();  
	}
		
	void OnTriggerEnter2D (Collider2D hit) {
		if (gameObject.CompareTag ("Zombie")) {
			score++; 
		}
	}
}
