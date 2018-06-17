﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("FireNave"))
		{
			Destroy(gameObject);
			GameController.instance.NaveScored (5);
		}
	}
}
