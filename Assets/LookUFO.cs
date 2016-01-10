using UnityEngine;
using System.Collections;

public class LookUFO : MonoBehaviour {

	Vector3 position;
	public GameObject alien;
	bool make = false;

	// Use this for initialization
	void Start () {	
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( transform.position.y <= 4.5f &&  make == false ) {
			Invoke("MakeAlien",0.3f);
			make = true;
		}
	}
	void MakeAlien() {
		Instantiate (alien,new Vector3(transform.position.x, 0f,transform.position.z -8f),alien.transform.rotation);
	}
}
