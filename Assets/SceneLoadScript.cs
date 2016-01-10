using UnityEngine;
using System.Collections;

public class SceneLoadScript : MonoBehaviour {

	public void MainScene() {
		Application.LoadLevel("main");
	}
	public void StoryScene() {
		Application.LoadLevel("Story");
	}
	public void EplanationScene() {
		Application.LoadLevel("Eplanation");
	}
	public void EplanationScene2 () {
		Application.LoadLevel("Eplanation2");
	}
	public void EplanationScene3 () {
		Application.LoadLevel("Eplanation3");
	}
	public void EplanationScene4 () {
		Application.LoadLevel("Eplanation4");
	}
	public void EplanationScene5 () {
		Application.LoadLevel("Eplanation5");
	}
	public void RankingsScene() {
		Application.LoadLevel("Rankings");
	}
	public void TitleScene() {
		Application.LoadLevel("title");
	}
	public void NextScene(){
		Application.LoadLevel("title");
	}
}