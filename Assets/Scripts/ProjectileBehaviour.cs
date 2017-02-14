using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileBehaviour : MonoBehaviour {

	private float atY;
	private float atX; 


	// Use this for initialization
	void Start () {
		atY = Random.Range (-4.0f, 2.0f); 
		atX = Random.Range (-9.0f, 9.0f);
		transform.position = new Vector3 (atX, atY); 

	}

	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Zombie")) {
			Destroy (other.gameObject);  
		}
	}


}
