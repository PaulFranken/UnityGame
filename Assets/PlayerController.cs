﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

	}
}