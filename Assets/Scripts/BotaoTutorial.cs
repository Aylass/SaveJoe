using UnityEngine;
using System.Collections; 

public class BotaoTutorial : MonoBehaviour {
	public string LevelToLoad;
	// Use this for initialization


	public void StartGame () {
		Application.LoadLevel ("Tutorial");
	
	}
	


	void Update () {
	
		//Application.LoadLevel ("Tutorial");
	}
}
