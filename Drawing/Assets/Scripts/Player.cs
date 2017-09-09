using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float StepLength;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal_axis = Input.GetAxis ("Horizontal");

		if(horizontal_axis > 0) {
			gameObject.transform.position += new Vector3 (StepLength, 0, 0);
		}
		if (horizontal_axis < 0) {
			gameObject.transform.position += new Vector3 (-StepLength, 0, 0);
		}
	}
}
