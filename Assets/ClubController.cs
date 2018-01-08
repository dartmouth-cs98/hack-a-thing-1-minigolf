using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubController : MonoBehaviour {

	public Transform apex;
	public Transform followthrough;
	public Transform equilibrium;

	public float upSpeed;
	public float downSpeed;
	public float neutralSpeed;

	public enum State {neutral, upswing, downswing};
	public State currState;

	void Start () {
		print ("Apex rotation is: " + apex.rotation);
		print ("Club rotation is: " + transform.rotation);

		currState = State.neutral;

		upSpeed = 50.0f;
		downSpeed = 100.0f;
		neutralSpeed = 50.0f;
	}

	void OnMouseUp () {
		if (currState == State.upswing) {
			currState = State.downswing;
		}
	}

	void OnMouseDown () {
		if (currState == State.neutral) {
			currState = State.upswing;
		}
	}

	// Raise the club while the mouse is held down. Swing the club when the mouse is released
	void Update () {
		float step;
		switch (currState) {
		case State.neutral:
			step = neutralSpeed * Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards(transform.rotation, equilibrium.rotation, step);
			break;

		case State.upswing:
			//print ("State is upswing");
			// print(transform.eulerAngles);
			step = upSpeed * Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards(transform.rotation, apex.rotation, step);
			break;

		case State.downswing:
			step = downSpeed * Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards (transform.rotation, followthrough.rotation, step);
			if (transform.rotation == followthrough.rotation) {
				currState = State.neutral;
			}
			break;
		}
	}
}