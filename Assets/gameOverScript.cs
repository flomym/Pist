using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {

	public GameObject GameOver;

	bool next = false;

	void Start () {
		GameOver = GameObject.Find("GameOver");

	}
	
	void Update(){
		if (levelTimeScript.finish == true){
			this.GetComponent<Text>().text  = "GAME OVER";
			if (levelTimeScript.next == true){
				Application.LoadLevel("title");
			}
			if ( levelTimeScript.erase == true){
				this.GetComponent<Text>().text = "";
			}
		}
	}
}