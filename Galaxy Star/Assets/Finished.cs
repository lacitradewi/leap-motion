using UnityEngine;
using System.Collections;

public class Finished : MonoBehaviour {

	void Update () {
		
		StartCoroutine (waitFor ());
		
	}
	
	IEnumerator waitFor(){
		
		yield return new WaitForSeconds (20);
		Application.LoadLevel (1);
	}
}
