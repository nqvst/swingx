﻿using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour
{

	public float raycastDist = 10;
	public float sensitivity = 6f;
	
	public virtual float vertical {
		get {
			return Input.GetAxis ("Vertical");
		} 
	}
	
	public virtual float horizontal {
		get {
			return Input.GetAxisRaw ("Horizontal");
		} 
	}

	void Start ()
	{
		
	}
	
	void Update ()
	{        
	
		if (vertical != 0) {        
			if (transform.localEulerAngles.z > 0) {
				transform.Rotate (0, 0, vertical * sensitivity * 30 * Time.deltaTime);
			} else {
				transform.Rotate (0, 0, vertical * -sensitivity * 30 * Time.deltaTime);
			}
		}
		if (horizontal < 0) {
			transform.rotation = Quaternion.Euler (0, 180, transform.localEulerAngles.z);
		}
		if (horizontal > 0) {
			transform.rotation = Quaternion.Euler (0, 0, transform.localEulerAngles.z);
		}
	}
}