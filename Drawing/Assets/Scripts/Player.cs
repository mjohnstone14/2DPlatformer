using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 10;
	public float jumpVelocity = 10;
	Transform myTrans, tagGround;
	Rigidbody2D myBody;
	public LayerMask playerMask;
	public bool isGrounded = false;

	// Use this for initialization
	void Start () {
		myBody = this.GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "tag_ground").transform;

	}

	// Update is called once per frame
	void FixedUpdate () {
		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);

		Move (Input.GetAxisRaw("Horizontal"));
		if (Input.GetButtonDown ("Jump")) {
			Jump ();
		}
	}

	public void Move(float horizontalInput) {
		Vector2 moveVel = myBody.velocity;
		moveVel.x = horizontalInput * speed;
		myBody.velocity = moveVel;

	}

	public void Jump() {
		if (isGrounded) {
			myBody.velocity += jumpVelocity * Vector2.up;
		}
	}
}
