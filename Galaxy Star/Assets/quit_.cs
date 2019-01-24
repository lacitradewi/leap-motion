﻿using UnityEngine;
using System.Collections;

public class quit_ : MonoBehaviour {

	private HandController handController;
	
	void Start(){
		GameObject gameControllerObject = GameObject.FindWithTag ("HandControl");
		if (gameControllerObject != null) {
			handController = gameControllerObject.GetComponent <HandController>();
		}
	}
	
	public void OnCollisionEnter(Collision collision)
	{
		RigidHand leapObj = collision.gameObject.GetComponent<RigidHand>();
		
		/*if (leapObj)
		{
			Debug.Log(leapObj.maxVelocity.magnitude);
			rigidbody.AddForceAtPosition(leapObj.maxVelocity * 200, leapObj.transform.position);
			
		}*/
		Application.Quit ();
		
		//sound.playOneShot ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
