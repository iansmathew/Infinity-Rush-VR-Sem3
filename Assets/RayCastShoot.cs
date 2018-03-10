using System.Collections;
using UnityEngine;

public class RayCastShoot : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float fireRate = 4f;
	public float impactforce = 30f;

	public Camera fpsCam;
	public ParticleSystem muzzleFlash; //https://www.youtube.com/watch?v=THnivyG0Mvo Brackey's at 8:27
	public GameObject impactEffect;		//9:26 

	//render laser var's
	public LineRenderer lineRend;
	public Transform laserSpawn;

	[SerializeField]
	private float laserTurnOffTime = 0.3f;

	private float nextTimeToFire = 0f;

	void Start(){
		lineRend = GetComponent<LineRenderer> ();
		lineRend.enabled = true;
	}

	void Update () {
		if (Input.GetButton ("Fire1")&& Time.time>=nextTimeToFire) 
		{
           
			nextTimeToFire = Time.time + 1f / fireRate;
			Shoot ();
		}
	}

	void Shoot ()
	{
       // Debug.Log("Fire");
        //muzzleFlash.Play();
		RaycastHit hit;
		//Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit) //Infinity Range
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log (hit.transform.name);

			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) {
				print ("Fire");
				lineRend.SetPosition (0, laserSpawn.position);
				lineRend.SetPosition (1, hit.point);
				lineRend.enabled = true;
				StartCoroutine (ToggleLaser ());
				target.TakeDamage (damage);
			} else {
				lineRend.enabled = false;
			}

			/*if (hit.rigidbody != null) {
				hit.rigidbody.AddForce (-hit.normal * impactforce);*/

				//lineRend.enabled = false
		
			//lineRend.enabled = false;
			GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy (impactGO, 2f);
		}

	}

	IEnumerator ToggleLaser()
	{
		yield return new WaitForSeconds (laserTurnOffTime);
		lineRend.enabled = false;
	}

}
