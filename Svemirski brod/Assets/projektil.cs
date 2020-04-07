using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projektil : MonoBehaviour {

	public float steta = 150f;
	public float GetDamage()
	{
		return steta;
	}
	public void Hit()
	{
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
