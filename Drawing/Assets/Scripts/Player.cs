using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 10;
	public float jumpVelocity = 20;
	public float gravity = 25;
	Transform myTrans, tagGround;
	Rigidbody2D rigidBody;
	public LayerMask playerMask;
	public bool isGrounded = false;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D>();
		myTrans = this.transform;
		tagGround = GameObject.Find (this.name + "tag_ground").transform;

	}

	// Update is called once per frame
	void FixedUpdate () {

		Vector2 velocity = rigidBody.velocity;
		velocity.x = Input.GetAxisRaw("Horizontal") * speed;

		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);

		if (Input.GetButtonDown ("Jump") && isGrounded) {
				velocity = Jump (velocity);
			}
			
		velocity.y += -gravity * Time.deltaTime;
		rigidBody.velocity = velocity;
	}
		//changes y velocity 
		Vector2 Jump(Vector2 velocity) {
			velocity.y = jumpVelocity;
			isGrounded = false;
			return velocity;
		}
}
	