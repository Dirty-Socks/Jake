using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce = 6f;
	private Rigidbody2D rigidBody;
	public Animator animator;

	void Start() {
		animator.SetBool ("isAlive", true);
	}

	// Use this for initialization
	void Awake () {
		rigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log ("Left Mouse Button Clicked");
			Jump ();
		}

		animator.SetBool("isGrounded", IsGrounded());
	}

	void Jump () {
		if (IsGrounded ()) {
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	public LayerMask groundLayer;

	bool IsGrounded() {
		if (Physics2D.Raycast (this.transform.position, Vector2.down, 0.2f, groundLayer.value)) {
			return true;
		} else {
			return false;
		}
	}


}
