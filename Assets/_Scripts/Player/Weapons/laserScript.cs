using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{

    public LineRenderer laserRend;
    public Transform laserSpawn;

    //public float 		damage;
    public float fireRate = 4.0f;

    private float firingDelay = 0f;
    private float laserToggleTime = 0.15f;
    private bool canShoot = false;

    void Start()
    {
        laserRend = GetComponent<LineRenderer>();
        laserRend.enabled = false;
    }

    public void Shoot()
    {
        if (VRTargetingScript.hitPos != null)
        {
            Debug.Log("laserFiring");
            laserRend.SetPosition(0, laserSpawn.position);
            laserRend.SetPosition(1, VRTargetingScript.hitPos);

            laserRend.enabled = true;
            //Invoke ("LaserToggle", 0.15f);
            StartCoroutine(LaserToggle());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (VRTargetingScript.canFire && Time.time >= firingDelay)
        {
            firingDelay = Time.time + 2.0f / fireRate;
            Shoot();
            VRTargetingScript.canFire = false;
        }
    }

    IEnumerator LaserToggle()
    {
        yield return new WaitForSeconds(laserToggleTime);
        laserRend.enabled = false;

    }

    /*void LaserToggle(){
		laserRend.enabled = false;
	}*/

}