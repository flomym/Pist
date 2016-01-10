using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOverScript : MonoBehaviour {

	public GameObject GameOver;

	bool next = false;

	void Start () {
		//this.gameObject.GetComponent<Text>().enabled = false;
		GameOver = GameObject.Find("GameOver");

	}
	
	void Update(){
		if (levelTimeScript.finish == true){
			//this.gameObject.GetComponent<Text>().enabled = true;
			this.GetComponent<Text>().text  = "GAME OVER";
			if (levelTimeScript.next == true){
				Application.LoadLevel("title");
			}
		}
	}
	private IEnumerator Wait() {
	    // ログ出力
	    Debug.Log ("1");
	 
	    // 1秒待つ
	    yield return new WaitForSeconds (1);
	    Debug.Log ("2");

	    Application.LoadLevel("title");
	}
}