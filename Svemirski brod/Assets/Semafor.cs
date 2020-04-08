using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Semafor : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Text myText = GetComponent<Text>();
        myText.text = prikazRezultata.rezultat.ToString();
        prikazRezultata.Reset();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
