using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public Rigidbody2D player;
	public int speed; 
	public AudioSource zombieCrash; 
	private SpriteRenderer playerSprite;
	private CapsuleCollider2D playerCollider;
	private string spriteDirection;


	// Use this for initialization
	void Start () {
		player = GetComponent <Rigidbody2D> ();
		playerCollider = GetComponent <CapsuleCollider2D> (); 
		playerSprite = GetComponent<SpriteRenderer> ();
		spriteDirection = "right"; 
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0.0f);
		transform.position += move * speed * Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			spriteDirection = "left"; 
			playerSprite.flipX = true; 
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			spriteDirection = "right";
			playerSprite.flipX = false; 
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Zombie")) {
			Destroy (other.gameObject); 
			zombieCrash.Play ();  
		} 
	}



}
