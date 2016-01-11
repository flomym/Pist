using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelTimeScript : MonoBehaviour {
	
	public Text timeGUI;
	public moveScript moveScript;
	public GameObject GameOver;
	public static bool finish = false;	//GAME OVERを表示
	public static bool next = false;	
	public static bool erase = false;	//GAME OVERを消去
	public static bool score = false;	//SCOREを表示
	
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
			if (time <= 0.0f) { //GAME OVERを表示
				//Time.timeScale = 0;
				finish = true;
				timeGUI.text = "0";

			}
			if ( time <= -2.0f) { //GAME OVERを消去
				erase = true;
			}
			if ( time <= -4.0f){
				score = true;
			}
		}
	}
	void Finish () {
		Application.LoadLevel("title");
	}
}