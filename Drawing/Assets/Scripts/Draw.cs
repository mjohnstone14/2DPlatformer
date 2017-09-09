using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {

	public GameObject cirlePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		if (Input.GetMouseButton(0)) {
			cirlePrefab.transform.position = new Vector3 (mousePos.x, mousePos.y, 1);
			Instantiate (cirlePrefab);
		}
	}
}
