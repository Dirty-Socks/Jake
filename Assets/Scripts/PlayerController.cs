using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpForce = 6f;
	private Rigidbody2D rigidBody;

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
	}

	void Jump () {
		rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
	}
}
