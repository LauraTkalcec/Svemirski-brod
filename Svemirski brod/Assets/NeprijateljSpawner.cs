using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeprijateljSpawner : MonoBehaviour {

	// Use this for initialization

	public GameObject neprijateljPrefab;
	public float sirina = 10f;
	public float visina = 5f;
	private bool movingDesno = true;
	public float brzina = 5f;
	private float xmax;
	private float xmin;
	void Start () {
		
		float distanceToCamera = transform.position.z - Camera.main.transform.position.z;
		Vector3 lijevaGranica = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceToCamera));
		Vector3 desnaGranica = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceToCamera));
		xmax = desnaGranica.x;
		xmin = lijevaGranica.x;
		OzivljavanjeNeprijatelja();
}
	public void OnDrawGizmos()
	{
		Gizmos.DrawWireCube(transform.position, new Vector3(sirina, visina));
	}
	// Update is called once per frame
	void Update () {
		if (movingDesno)
		{
			transform.position += Vector3.right * brzina * Time.deltaTime;
		}
		else
		{
			transform.position += Vector3.left * brzina * Time.deltaTime;
		}
		float desnaGranicaFormacije = transform.position.x + (0.5f * sirina);
		float lijevaGranicaFormacije = transform.position.x - (0.5f * sirina);
		if (lijevaGranicaFormacije < xmin)
		{
			movingDesno = true;
		}
		else if (desnaGranicaFormacije > xmax)
		{
			movingDesno = false;
		}
		if (AllMembersDead())
		{
			Debug.Log("praznaformacija");
		}

	}
	bool AllMembersDead()
	{
		foreach (Transform childPositionGameObject in transform)
		{
			if(childPositionGameObject.childCount > 0)
			{
				return false;
			}
		}
		return true;
	}

	void OzivljavanjeNeprijatelja()
	{
		foreach (Transform child in transform)
		{
			GameObject neprijatelj = Instantiate(neprijateljPrefab, child.transform.position, Quaternion.identity) as GameObject;
			neprijatelj.transform.parent = child;
		}
	}
}
