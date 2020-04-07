using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel (string name) {
		Debug.Log("Učitavanje razine " + name);
		Application.LoadLevel(name);
		
	}
	
	// Update is called once per frame
	public void QuitRequest () {
		Debug.Log("Gašenje!");
		Application.Quit();
		
	}
}
