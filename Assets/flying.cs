﻿using UnityEngine;
using System.Collections;

public class flying : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);
	

	void Update () {
		if (Input.GetKeyUp("space"))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
	}
}
