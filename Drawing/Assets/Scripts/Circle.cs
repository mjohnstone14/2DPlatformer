using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	public float timetowait;
	float timer;

	// Use this for initialization
	void Start () {
		timer = timetowait;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			Destroy (gameObject);
		}
	}
}
