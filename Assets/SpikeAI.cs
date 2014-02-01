using UnityEngine;
using System.Collections;

public class SpikeAI : MonoBehaviour {
	
	public float moveSpeed = 5f;
	public float moveForce = 365f;
	public float moveLeft = 0;

	//private Animator anim;

	void Awake () {
		//anim = GetComponent<Animator>();
		moveLeft -= 1;
	}

	// Update is called once per frame
	void FixedUpdate () {
		//if(rigidbody2D.velocity.x < maxSpeed)
			// ... add a force to the player.
		rigidbody2D.velocity = new Vector2(transform.localScale.x * moveLeft * moveSpeed,rigidbody2D.velocity.y);
		Debug.Log ("Move Dang it!");
		//rigidbody2D.AddForce(Vector2.right * moveForce);
		//Debug.Log ("Moving Opossums");
	}
}
