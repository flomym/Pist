using UnityEngine;
using System.Collections;

public class movePanel : MonoBehaviour {

	Hashtable table = new Hashtable();		// ハッシュテーブルを用意
	GameObject Panel;
	// Use this for initialization
	private void Start () {
		Panel = GameObject.Find("Panel");
		Panel.transform.localPosition = new Vector3(0f, -1175f, 0f);
		table.Add("y", 1500);			// yを移動
		table.Add("time", 200.0f);		// トゥイーン時間は3秒
		table.Add("delay", 3.0f);		// 1秒遅らせてからトゥイーンスタート
		iTween.MoveTo(Panel, table);	// 第二引数にハッシュテーブルをセット
		//iTween.MoveTo(Panel, iTween.Hash("y", 10, "speed", 15.0f));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)){
			Application.LoadLevel ("title");
		}
	
	}
}