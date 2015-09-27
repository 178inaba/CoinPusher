using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {

	void OnCollisionEnter(Collision colObject) {
		if (colObject.gameObject.tag == "Coin") {
			Destroy(colObject.gameObject);
		}
	}
}
