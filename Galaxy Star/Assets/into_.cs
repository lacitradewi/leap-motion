using UnityEngine;
using System.Collections;

public class into_ : MonoBehaviour {

	void Update () {

		StartCoroutine (waitFor ());

		}

	IEnumerator waitFor(){
		
		yield return new WaitForSeconds (10);
		Application.LoadLevel (5);
	}
}
