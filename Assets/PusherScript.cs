using UnityEngine;
using System.Collections;

public class PusherScript : MonoBehaviour {

	Vector3 initPosition;
	Vector3 newPosition;

	// Use this for initialization
	void Start () {
		// save first position
		initPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// update position
		newPosition = new Vector3 (initPosition.x,
		                           initPosition.y,
		                           initPosition.z + Mathf.Sin(Time.time));

		// move
		this.GetComponent<Rigidbody> ().MovePosition (newPosition);
	}
}
