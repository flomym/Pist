using UnityEngine;
using System.Collections;

public class createScript : MonoBehaviour {

	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;

	public Vector3 position1;
	public Vector3 position2;
	public Vector3 position3;
	public Vector3 position4;

	Vector3 position;

	float enemyBorder = 60;
	float x = 0;

	void Update ()
	{
		if (transform.position.z > enemyBorder) {
			CreateEnemy ();
		}
	}

	void CreateEnemy (){

		//UFOを生成
		if (Random.Range (0, 3) == 0) {
			position1 = new Vector3 (Random.Range(-30f,-25f), 15f, enemyBorder + 350f);
			Instantiate (enemy1, position1, enemy1.transform.rotation);
		}
		else if (Random.Range (0, 3) == 0) {
			position2 = new Vector3 (Random.Range(25f,40f), 15f, enemyBorder + 350f);
			Instantiate (enemy2, position2, enemy2.transform.rotation);
		}
		else if (Random.Range (0, 3) == 0) {
			position3 = new Vector3 (Random.Range(-40f,-60f), 15f, enemyBorder + 350f);
			Instantiate (enemy3, position3, enemy3.transform.rotation);
		}
		else if (Random.Range (0, 3) == 0) {
			position4 = new Vector3 (Random.Range(30f,20f), 15f, enemyBorder +350f);
			Instantiate (enemy4, position4, enemy4.transform.rotation);
		}
		enemyBorder += 50;
	}
}