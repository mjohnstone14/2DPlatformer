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
//		Vector2 between = position_1 - position_0;
//		// base case to stop recursion
//		if (between.magnitude < 2) {
//			return;
//		}
//		Debug.Log (between.magnitude);
//		Vector2 newPos = (between / 2) + position_0;
//		circlePrefab.transform.position = newPos;
//		Instantiate (circlePrefab);
//
//		DrawCirlesBetweenPoints (position_0, between / 2);
//		DrawCirlesBetweenPoints (between / 2, position_1);

//		**********************************************************************************

		Vector2 start = position_0;
		Vector2 end = position_1;

		Vector2 between = new Vector2 (2, 2);
		while (between.magnitude > .5) {
			between = position_1 - position_0;
			Vector2 newPos = (between / 2) + position_0;
			circlePrefab.transform.position = newPos;
			Instantiate (circlePrefab);
			position_0 = start;
			position_1 = between / 2;

		}
	}
}
