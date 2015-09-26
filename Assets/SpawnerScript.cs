using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	float moveSpeed = 2.0f;
	Rigidbody rb;

	public GameObject coin;

	// wall
	public GameObject leftWall;
	public GameObject rightWall;
	float leftWallPositionX;
	float rightWallPositionX;

	// score
	public GameObject scoreText;
	ScoreScript scoreS;

	// Use this for initialization
	void Start () {
		// get Rigidbody
		rb = this.GetComponent<Rigidbody> ();

		// get wall x position
		leftWallPositionX = leftWall.transform.position.x;
		rightWallPositionX = rightWall.transform.position.x;

		// get score script
		scoreS = scoreText.GetComponent<ScoreScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		// get now position
		Vector3 currentPosition = this.transform.position;

		// set move range min and max
		currentPosition.x = Mathf.Clamp (currentPosition.x,
		                                 leftWallPositionX,
		                                 rightWallPositionX);

		// set position
		this.transform.position = currentPosition;

		// input horizontal key to move
		float x = Input.GetAxis ("Horizontal");

		// move of x axis
		Vector3 direction = new Vector3 (x, 0, 0);

		// move speed decision
		rb.velocity = direction * moveSpeed;

		if (Input.GetKeyDown("space")) {
			// create coin
			Instantiate(coin, this.transform.position, this.transform.rotation);

			scoreS.subScore(1);
		}
	}
}
