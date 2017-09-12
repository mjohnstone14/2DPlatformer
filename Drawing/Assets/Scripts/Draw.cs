using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {

	public GameObject circlePrefab;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	
		if (Input.GetMouseButton(0)) {
			circlePrefab.transform.position = new Vector3 (mousePos.x, mousePos.y, 1);
			Instantiate (circlePrefab);

		}
	}
}
