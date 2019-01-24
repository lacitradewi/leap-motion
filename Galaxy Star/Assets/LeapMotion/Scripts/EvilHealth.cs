using UnityEngine;
using System.Collections;

public class EvilHealth : MonoBehaviour {
	public int maxHealth = 300;
	public static int curHealth = 300;
	public GameObject explosion;
	public float healthBarLength;
	public GameObject Objek;

	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
		AddjustCurrentHealth (0);
		if (curHealth == 0) {
			Destroy (Objek);
			Destroy (gameObject);
			if(explosion != null){
				Instantiate(explosion, transform.position, transform.rotation);
			}
		}
	}

	void OnGUI(){
		GUI.Box(new Rect(10,10,Screen.width / 2 / (maxHealth / curHealth),20), curHealth+ "/" + maxHealth);
	}

	public void AddjustCurrentHealth(int adj) {
		curHealth += adj;

		if (curHealth < 0)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;

		if (curHealth < 1)
			curHealth = 1;

		healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);

	}

	void OnTriggerExit (Collider other) 
	{
		curHealth = curHealth - 10;
	}
}
