using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script to return the hit position of the GVR reticle in a vector3
//currently changing colors of objects when gazed at as well.

public class VRTargetingScript : MonoBehaviour {

	private Vector3 hitPos;
	private bool canFire = false;

    //Public Getters
    public Vector3 GetHitPos
    {
        get { return hitPos; }
    }
    public bool GetCanShoot
    {
        get { return canFire; }
        set { canFire = value; }
    }

    //Instance property
    public static VRTargetingScript Instance { get; private set; }

    /* -- MEMBER FUNCTIONS --*/

    void Start () {
        if (Instance != null)
        {
            Destroy(gameObject); //ensuring that only one instance is active
            return; //redundant?
        }
        else
        {
            Instance = this;
        }
	}

	public void Fire(){
		canFire = true;
		hitPos = GvrPointerInputModule.CurrentRaycastResult.gameObject.transform.position;
        //TODO: Colin - Call enemy function
	}
}
