using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {
	
	public Rigidbody rb;
	public static Vector3 carpos;
	GameObject Camera;

	void Start() {
		rb = GetComponent<Rigidbody>();
		//Camera = GameObject.FindWithTag("MainCamera");
	}
	
	void Update() {
		if ( Countdown.StartGame == true) {
			rb.velocity = new Vector3(rb.velocity.x, -5f, 30f);
			carpos = rb.velocity;
			//Camera.transform.localPosition = new Vector3 (0f, 6f, -5f);

		}
	}
}
