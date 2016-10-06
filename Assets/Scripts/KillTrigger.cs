using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			//Debug.Log ("Player collider entered the trigger");
			PlayerController.instance.Kill();
		}
	}

	void Start () {

	}

}
