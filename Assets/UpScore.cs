using UnityEngine;
using System.Collections;
//********** 開始 **********//
using UnityEngine.UI;
//********** 終了 **********//
 
public class UpScore : MonoBehaviour {
	
	public GameObject player;
	public GameObject alien;

	public Text scoreText; //Scoreを画面に表示
	public static int score = 0; //スコア計算用変数
	
	private Transform playerTrans;
	
	void Start (){
		playerTrans = player.GetComponent<Transform>();
	}
	        
	void Update () {
	    if (Input.GetMouseButtonDown(0)) {

	        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	        RaycastHit hit = new RaycastHit();
	 
	        if (Physics.Raycast(ray, out hit,10000000,1 << 8)){
	            GameObject obj = hit.collider.gameObject;

	            if (obj.name.ToString() == "UFO(Clone)" || obj.name.ToString() == "Alien(Clone)"){
	            	score += 20;
	            	Destroy(obj);
	            	this.GetComponent<Text>().text  = score.ToString();
	  
	            }
	        }
	    } 
	}
}