using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.A)){
			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z+3.0f);
		}
	}
}
