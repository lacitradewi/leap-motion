using UnityEngine;
using System.Collections;

public class rot_ : MonoBehaviour {

	public float rotSpeed;
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (waitFor ());
		transform.Rotate(new Vector3(-1,0,0),rotSpeed * Time.deltaTime,Space.World);
	}

	IEnumerator waitFor(){
		
				yield return new WaitForSeconds (10);
				Application.LoadLevel (1);
		}
}
