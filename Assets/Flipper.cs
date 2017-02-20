﻿using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

	public KeyCode flipKey;
	private JointMotor jointMotor;

	void Start () {
		jointMotor = GetComponent<HingeJoint> ().motor;
	}

	void Update () {
		if(Input.GetKeyDown(flipKey) || Input.GetKeyUp(flipKey)){
			jointMotor.targetVelocity = -jointMotor.targetVelocity;
			GetComponent<HingeJoint> ().motor = jointMotor;
		}
	}
}
