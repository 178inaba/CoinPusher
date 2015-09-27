using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {

	public GameObject scoreText;
	ScoreScript scoreS;

	void Start() {
		scoreS = scoreText.GetComponent<ScoreScript> ();
	}

	void OnCollisionEnter(Collision colObject) {
		if (colObject.gameObject.tag == "Coin") {
			// delete object
			Destroy(colObject.gameObject);

			scoreS.addScore(2);
		}
	}
}
