using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.transform.position.y <= -6) {
			Player.transform.position = new Vector3 (-6, -2.57f, 0);
			Player.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
		}
	}
}
