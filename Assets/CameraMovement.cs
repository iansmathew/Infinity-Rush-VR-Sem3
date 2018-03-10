using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	[SerializeField]
	private Transform holder;
	// Use this for initialization
	void Start () {
		Camera main;		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//float x = 0;
		float x = 1 * Input.GetAxis ("Mouse X"); //This is the new "Up and Down"
		//float y = 0;
		float y = 1 * -Input.GetAxis ("Mouse Y"); //This is the new "Left and Right"
		Camera.main.transform.Rotate (y, x, 0);
		//Camera.main.transform.RotateAround(transform.position, -Vector3.forward, x);
		//holder.RotateAround (transform.position, Vector3.right, y);
		// declare the RaycastHit variable

	}
}

