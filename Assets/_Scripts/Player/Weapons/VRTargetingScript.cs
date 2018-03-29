using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script to return the hit position of the GVR reticle in a vector3
//currently changing colors of objects when gazed at as well.

public class VRTargetingScript : MonoBehaviour
{
    public static Vector3 hitPos;
    public static bool canFire = false;

    public void Fire()
    {
        canFire = true;
        GameObject objectHit = GvrPointerInputModule.CurrentRaycastResult.gameObject;
        hitPos = objectHit.transform.position;

        if (objectHit.tag == "Enemy")
        {
            objectHit.GetComponent<EnemyMove>().TakeHit(50);
        }
        else if (objectHit.tag == "Asteroid")
        {
            //TODO: Call asteroid hit
        }
    }
}