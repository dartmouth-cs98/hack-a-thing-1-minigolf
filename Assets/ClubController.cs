using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubController : MonoBehaviour {

	public float angleIncrement = .5f;
	public float upSpeed = 2.0f;
	public float downSpeed = 100.0f;

	public Transform pivot;

	// Use this for initialization
	void Start () {
		pivot = GetComponent<Transform> ();
	}

	void OnMouseDown () {
//		while (pivot.localRotation.eulerAngles.z < 120) {
//			pivot.RotateAround (pivot.position, -pivot.forward, angleIncrement * upSpeed);
//		}
	}

	void OnMouseUp () {

	}

	void Update () {
		if (Input.GetMouseButton (0)) {
			print (pivot.localEulerAngles);
			if (pivot.localEulerAngles.z > 240 || pivot.localEulerAngles.z < 120) {
				pivot.RotateAround (pivot.position, -pivot.forward, angleIncrement * upSpeed);
			}
		}
	}
}
