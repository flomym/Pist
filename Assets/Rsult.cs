using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rsult : MonoBehaviour {

	public GameObject rsult;
	// Use this for initialization
	void Start () {
		rsult = GameObject.Find("Rsult");
	}
	
	// Update is called once per frame
	void Update () {
		if ( levelTimeScript.score == true){
			this.GetComponent<Text>().text = "score :" ;
		}
	}
}
