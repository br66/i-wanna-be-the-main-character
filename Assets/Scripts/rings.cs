﻿using UnityEngine;
using System.Collections;

public class rings : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Application.LoadLevel("2sonic");
		}
	}
}
