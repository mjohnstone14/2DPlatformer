using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {

	public GameObject circlePrefab;
	public GameObject player;

	private Vector2 mouseLastPos;
	private bool clicked;

	// Use this for initialization
	void Start () {
		clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	
		if (Input.GetMouseButton (0)) {

			// Check to see if this is the first update since the mouse was clicked, in 
			// which case there will be no last position for the mouse, so we want to set
			// mouseLastPos to the current position of the mouse
			if (!clicked) {
				mouseLastPos = mousePos;
				clicked = true;
			}

			circlePrefab.transform.position = new Vector3 (mousePos.x, mousePos.y, 1);
			Instantiate (circlePrefab);

			DrawCirlesBetweenPoints (mouseLastPos, mousePos);

			mouseLastPos = mousePos;
		} else {
			clicked = false;
		}
	}

	private void DrawCirlesBetweenPoints(Vector2 position_0, Vector2 position_1) {
		Vector2 between = position_1 - position_0;

		// base case to stop recursion
		if (between.magnitude < .5) {
			return;
		}

		Vector2 newPos = (between / 2) + position_0;
		circlePrefab.transform.position = newPos;
		Instantiate (circlePrefab);

		DrawCirlesBetweenPoints (position_0, newPos);
		DrawCirlesBetweenPoints (newPos, position_1);
	}
}
