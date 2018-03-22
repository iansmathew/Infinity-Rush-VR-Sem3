using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightLaserScript : MonoBehaviour {

	public LineRenderer laserRend2;
	public Transform 	laserSpawn2;

	//public float 		damage;
	public float 		fireRate = 4.0f;

	private float		firingDelay = 0f;
	private float 		laserToggleTime = 0.15f;

	void Start () {
		laserRend2 = GetComponent<LineRenderer> ();
		laserRend2.enabled = false;
	}

	public void Shoot(){
		if (VRTargetingScript.Instance.GetHitPos != null) {
			//Debug.Log ("laserFiring");
			laserRend2.SetPosition (0, laserSpawn2.position);
			laserRend2.SetPosition (1, VRTargetingScript.Instance.GetHitPos);

			laserRend2.enabled = true;
			//Invoke ("LaserToggle", 0.15f);
			StartCoroutine (LaserToggle ());
		}
	}

	// Update is called once per frame
	void Update () {
		if (VRTargetingScript.Instance.GetCanShoot && Time.time >= firingDelay) {
			firingDelay = Time.time + 2.0f / fireRate;
			Shoot ();
			VRTargetingScript.Instance.GetCanShoot = false;
		}
	}

	IEnumerator LaserToggle(){
		yield return new WaitForSeconds (laserToggleTime);
		laserRend2.enabled = false;

	}

	/*void LaserToggle(){
		laserRend2.enabled = false;
	}*/

}
