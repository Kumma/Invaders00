﻿using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown ("space")) {
			Instantiate (bullet, transform.position + new Vector3(0, 1, 0), transform.rotation);
		}
	}
}
