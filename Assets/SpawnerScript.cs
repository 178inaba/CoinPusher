using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	float moveSpeed = 2.0f;
	Rigidbody rb;

	public GameObject coin;

	// Use this for initialization
	void Start () {
		// get Rigidbody
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		// input horizontal key to move
		float x = Input.GetAxis ("Horizontal");

		// move of x axis
		Vector3 direction = new Vector3 (x, 0, 0);

		// move speed decision
		rb.velocity = direction * moveSpeed;

		if (Input.GetKeyDown("space")) {
			// create coin
			Instantiate(coin, this.transform.position, this.transform.rotation);
		}
	}
}
