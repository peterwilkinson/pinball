using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Player"){ // collision.gameObject.tag == "Player"
			print("Hit");
//			transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z+0.1f);
			collision.gameObject.GetComponent<Rigidbody> ().AddExplosionForce (400.0f, this.transform.position, 10.0f);
		}
	}
}
