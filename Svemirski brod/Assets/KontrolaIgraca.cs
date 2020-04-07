using System.Collections;
using UnityEngine;

public class KontrolaIgraca : MonoBehaviour {

	// Use this for initialization

	public float brzina = 15.0f;
	float xmin;
	float xmax;
	public GameObject projektil;
	public float brzinaProjektila;
	public float snaga = 250;

	void OnTriggerEnter2D(Collider2D collider)
	{
		projektil missile = collider.gameObject.GetComponent<projektil>();
		if (missile)
		{
			snaga -= missile.GetDamage();
			missile.Hit();
			if (snaga <= 0)
			{
				Die();
			}
		}
	}
	void Die()
	{
		LevelManager man = GameObject.Find("LevelManager").GetComponent<LevelManager>();
		man.LoadLevel("Win");
		Destroy(gameObject);
	}
	void Start ()
	{
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 krajnjelijevo = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 krajnjedesno = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
		xmin = krajnjelijevo.x;
		xmax = krajnjedesno.x;
			}
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * brzina * Time.deltaTime;
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * brzina * Time.deltaTime;
		}
		float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
		transform.position = new Vector3(newX, transform.position.y, transform.position.z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject laser = Instantiate(projektil, transform.position, Quaternion.identity) as GameObject;
			laser.GetComponent<Rigidbody2D>().velocity = new Vector3(0, brzinaProjektila, 0);
		}
	}
	
	// Update is called once per frame
	
}
