using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class prikazRezultata : MonoBehaviour {
	public static int rezultat = 0;
	private Text myText;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text>();
		Reset();
	}
	public void Rezultat(int points)
	{
		Debug.Log("Rezultat");
		rezultat += points;
		myText.text = rezultat.ToString();
	}
	
	// Update is called once per frame
	public static void Reset () {
		rezultat = 0;
		
	}
}
