using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script to return the hit position of the GVR reticle in a vector3
//currently changing colors of objects when gazed at as well.

public class VRTargetingScript : MonoBehaviour {

	[SerializeField] public Material mat1;
	[SerializeField] public Material mat2;

	public static Vector3 hitPos;
	public static bool canFire = false;

	/*public bool canShoot {
		get{ return canShoot;}
		set{ canShoot = canFire;}
	}*/

	void Start () {
		GetComponent<Renderer> ().material = mat1;
	}

	public void Targeting(){
		GetComponent<Renderer> ().material = mat2;

	}

	public void notTargeting(){
		GetComponent<Renderer> ().material = mat1;
	}

	public void Fire(){
		canFire = true;
		hitPos = GvrPointerInputModule.CurrentRaycastResult.gameObject.transform.position;
		Debug.Log (hitPos);
	}
}
