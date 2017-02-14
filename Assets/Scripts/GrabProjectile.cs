using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabProjectile : MonoBehaviour {

	public bool grabbed;
	RaycastHit2D hit;
	public float distance = 2f; 
	public Transform hold;
	public float throwForce; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Mouse0)) {


			if (!grabbed) { 

				Physics2D.queriesStartInColliders = false; 
				hit = Physics2D.Raycast (transform.position, Vector2.right * transform.localScale.x, distance);

				if (hit.collider.CompareTag("Projectile")) {
					grabbed = true; 
				}


			} else {
				grabbed = false; 

				if (hit.collider.gameObject.GetComponent<Rigidbody2D> () != null) {

					hit.collider.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-transform.position.x, 1) * throwForce;
				}
			}

			if(grabbed) {
				hit.collider.gameObject.transform.position = hold.position;
			}
		}



	}
}
