using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveAlien : MonoBehaviour {

	public Text score;
	public GameObject alien;
	public Rigidbody rb;

	bool collider = false;
	int cnt = 0;
	
	GameObject Camera;

	// Use this for initialization
	void Start () {
		Camera = GameObject.Find("Main Camera");
		rb = GetComponent<Rigidbody>();
		score = GameObject.Find("ScoreText").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log("Camera = "+Camera.transform.position.z);

		if ( Countdown.StartGame == true) {

			if ( (alien.transform.position.z - Camera.transform.position.z) < 3.0f){
				if( collider == false){
					UpScore.score -= 10;
					score.text = UpScore.score.ToString();
					collider = true;
				}
			}
			//エイリアンを車に向かわせる	
			if ( alien.transform.position.x < -10f) {
				rb.velocity = new Vector3(10f, rb.velocity.y, -35f);
			}
			else rb.velocity = new Vector3(-10f,rb.velocity.y,-35f);

			//エイリアンが車に当たるとスコアを−１０にする
			/*if ( (Mathf.Sqrt(Mathf.Pow(alian.transform.position.x – rb.velocity.x, 2) + Mathf.Pow (alian.transform.position.y – rb.velocity.y, 2) < 5.0000000f) {

				ScoreText.SendMessage("MinusScore");
				Debug.Log("メッセージ送信");
			}*/
		}
	}
}
