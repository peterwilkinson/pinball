using UnityEngine;
using System.Collections;

public class PinballSpawner : MonoBehaviour {

	public GameObject pinball;

	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			pinball.transform.position = this.transform.position;
			Instantiate (pinball);
		}
	}
}
