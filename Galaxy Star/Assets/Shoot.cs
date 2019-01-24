using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	
	private float nextFire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		{
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

		}
	
	}

}
