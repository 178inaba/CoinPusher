using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {

	public GameObject scoreText;
	ScoreScript scoreS;

	AudioSource getSE;

	void Start() {
		scoreS = scoreText.GetComponent<ScoreScript> ();
		getSE = this.GetComponent<AudioSource> ();
	}

	void OnCollisionEnter(Collision colObject) {
		if (colObject.gameObject.tag == "Coin") {
			// delete object
			Destroy(colObject.gameObject);

			scoreS.addScore(2);

			// play se
			getSE.PlayOneShot(getSE.clip);
		}
	}
}
