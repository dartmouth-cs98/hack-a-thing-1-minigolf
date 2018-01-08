using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public Rigidbody rb; 

	public float thrust; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		thrust = 5f; 
	}

	void OnCollisionEnter (Collision col) {
		print ("collision detected with: " + col.gameObject.name);
		print ("impulse: " + col.impulse);
		if (col.gameObject.name == "head") {
			rb.AddForce(transform.right * thrust);
		}
	}
}
