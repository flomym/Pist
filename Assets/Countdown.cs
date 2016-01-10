using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {

	public Text timeGUI;
	public moveScript moveScript;
	public static bool StartGame = false;
	GameObject count;

	private float time = 4.00f;

	void Start() {
		count = GameObject.Find("Count");
		//timeGUI.text = time.ToString();
	}

	void Update() {
		time -= 1f * Time.deltaTime;
		if ( time > 1.00) {
			timeGUI.text = ((int)time).ToString();
		}
		else if ( time >= 0.00 && 1.00 >= time ){
			timeGUI.text = "GO!!";
		}
		else if (time <= 0.00f){
			count.SetActive(false);
			StartGame = true;
		}
	}
}