using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public static PlayerController instance;

	public float jumpForce = 6f;
	public float runningSpeed = 1.5f;
	public Animator animator;

	private Rigidbody2D rigidBody;
	private Vector3 startingPosition;

	void Awake () {
		rigidBody = GetComponent<Rigidbody2D> ();
		instance = this;
		startingPosition = this.transform.position;
	}

	public void StartGame() {
		animator.SetBool ("isAlive", true);
		this.transform.position = startingPosition;
	}
		
	void Update () {
		if (GameManager.instance.currentGameState == GameState.inGame) {
			if (Input.GetMouseButtonDown (0)) {
				Jump ();
			}
			animator.SetBool ("isGrounded", IsGrounded ());
		}
	}

	void FixedUpdate () {
		if (GameManager.instance.currentGameState == GameState.inGame) {
			if (rigidBody.velocity.x < runningSpeed) {
				rigidBody.velocity = new Vector2 (runningSpeed, rigidBody.velocity.y);
			}
		}
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

	public void Kill () {
		GameManager.instance.GameOver ();
		animator.SetBool ("isAlive", false);
	}
}
