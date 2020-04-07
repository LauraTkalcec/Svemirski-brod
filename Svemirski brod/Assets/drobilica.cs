using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drobilica : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col) 
	{
		Destroy(col.gameObject);	
	}
	
	// Update is called once per frame
	
}
