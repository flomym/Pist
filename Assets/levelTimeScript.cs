using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelTimeScript : MonoBehaviour {
	
	public Text timeGUI;
	public moveScript moveScript;
	public GameObject GameOver;
	public static bool finish = false;
	public static bool next = false;
	
	private float time = 60f;
	private int countBorder = 2000;
	private int count = 0;
	
	void Start () {
		GameOver = GameObject.Find("GameOver");
		timeGUI.text = 	time.ToString();	//スコアの値を表示
		//GameOver.gameObject.GetComponent<Text>().enabled = false;	
	}
	
	void Update() {
		//タイム
		if ( Countdown.StartGame == true ) {
			time -= 1f * Time.deltaTime;
			timeGUI.text = ((int)time).ToString();
			//レベル
			if (transform.position.z >= countBorder) {
				countBorder += 2000;
				count++;
				time += 100f;
			}
			if (time <= 0.0f) {
				//Time.timeScale = 0;
				finish = true;
				timeGUI.text = "0";

			}
			if ( time <= -2.0f) {
				Debug.Log("２秒たったよー");
				next = true;
			}
		}
	}
	void Finish () {
		Application.LoadLevel("title");
	}
}