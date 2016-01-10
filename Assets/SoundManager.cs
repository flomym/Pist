using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	
	//public AudioSource musicSource; //BGM用AudioSource
	public static SoundManager instance = null;
	//音の高さにバリエーションを付ける用の変数
	public float lowPitchRange = .95f;
	public float highPitchRange = 1.05f;

	void Start() {
		var musicSource = GetComponent<AudioSource>();
		musicSource.Play();
		Debug.Log("出力");
	}
	//シングルトンの処理
	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		DontDestroyOnLoad (gameObject);
		//musicSource.Play();
	}
	
	//BGMの再生
	/*public void PlaySingle (AudioClip clip)
	{
		musicSource.clip = clip;
		musicSource.Play();
	}*/
}
