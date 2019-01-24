using UnityEngine;
using System.Collections;

public class credit : MonoBehaviour {

	public GameObject camera;
	public float speed;
	
	// Update is called once per frame
	void Update () {

				transform.Translate (Vector3.up * Time.deltaTime * speed);
		StartCoroutine (waitFor ());

		}

	IEnumerator waitFor(){

		yield return new WaitForSeconds (17);
		Application.LoadLevel (1);

	}
}
