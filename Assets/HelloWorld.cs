using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World script started");

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Hello World script running");
		transform.Translate (.1f, .1f, .1f);
	}
}
