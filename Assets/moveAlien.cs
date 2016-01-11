using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveAlien : MonoBehaviour {

	public Text score;
	public GameObject alien;
	public Rigidbody rb;

    public int life = 5;    //体力

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
		}
	}
}
