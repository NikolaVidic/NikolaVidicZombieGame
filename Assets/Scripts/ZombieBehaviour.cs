using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour {

	private float speed;
	private float posY;

	// Use this for initialization
	void Start () {
		speed = 0.05f; 
		posY = Random.Range (-4.0f, 2.0f); 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x - speed, posY);
	}
		
}