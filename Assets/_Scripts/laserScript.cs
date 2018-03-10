using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour {

	public LineRenderer lineRenderer;
	public Transform laserSpawn;


	void Start () {
		lineRenderer =  gameObject.GetComponent<LineRenderer> ();
		lineRenderer.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		/*lineRenderer.SetPosition (0, laserSpawn.position);
		RaycastHit hit;
		if (Physics.Raycast (laserSpawn.position, transform.forward, out hit)) {
			if (GetComponent<RayCastShoot> ().isFiring ()) {
				lineRenderer.SetPosition (1, hit.point);
				//lineRenderer.enabled = true;
			}
		} else {
			lineRenderer.SetPosition (1, laserSpawn.position);
		}*/
	}
}
