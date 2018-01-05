using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public Rigidbody rb; 

	public float thrust; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		thrust = 500; 
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		rb.AddForce(transform.forward * thrust); 
		rb.useGravity = true; 
	}
}
