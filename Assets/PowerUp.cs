using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Need to use the UI, when we Need the UI
//using UnityEngine.UI;



public class PowerUp : MonoBehaviour {

	public GameObject pickupEffect;
	public float multiplier = 2.0f;
	public float duration = 10.0f;
	public float addedBonus = 100f;
	public float minusBonus = 10f;


	//Version 1 - a Temporary Bonus, expires after X Time

//	void OnTriggerEnter (Collider other)
//	{
//		if (other.CompareTag ("Player")) 
//		{
//			StartCoroutine (Pickup (other));
//		}
//	}
//	IEnumerator Pickup(Collider player)
//		{
//			Debug.Log ("PowerUp Picked Up!");
//			//Spawn Cool Effect
//			//This Instantiate won't work because we want the effect to appear on the UI
//			Instantiate(pickupEffect, Transform.position, transform.rotation);
//			//Turn the "Got IT" on the UI
//	
//	
//	
//	
//			//Apply Effect to the player
//			//This needs to get modified to whatever we call the player stats
//	
//			PlayerStats stats = player.GetComponent<PlayerStats>();
//			stats.health *= multiplier;
//	
//		GetComponent<MeshRenderer> ().enabled = false;
//		GetComponent<Collider> ().enabled = false;
//
//			//wait
//		yield return new WaitForSeconds(duration);
//	
//			stats.heath /= multiplier;
//			//Remove Power Up
//			Destroy(gameObject);
//		}





	//Version 02 - Health, It's a permanent thing

//	void OnTriggerEnter (Collider other)
//	{
//		if (other.CompareTag ("Player")) 
//		{
//			Pickup (other);
//		}
//	}
//
//	void Pickup(Collider player)
//	{
//		Debug.Log ("PowerUp Picked Up!");
//		//Spawn Cool Effect
//		//This Instantiate won't work because we want the effect to appear on the UI
//		Instantiate(pickupEffect, Transform.position, transform.rotation);
//		//Turn the Got It Effect on the UI
//
//
//
//
//		//Apply Effect to the player
//		//This needs to get modified to whatever we call the player stats
//
//		PlayerStats stats = player.GetComponent<PlayerStats>();
//		stats.health += addedBonus;
//
//				GetComponent<MeshRenderer> ().enabled = false;
//				GetComponent<Collider> ().enabled = false;
//
//
//
//		//Remove Power Up
//		Destroy(gameObject);
//	}





	//Version 03 - Damage 

//	void OnTriggerEnter (Collider other)
//	{
//		if (other.CompareTag ("Player")) 
//		{
//			Pickup (other);
//		}
//	}
//
//	void Pickup(Collider player)
//	{
//		Debug.Log ("You've Been Hit!");
//		//Spawn Cool Effect
//		//This Instantiate won't work because we want the effect to appear on the UI
//		Instantiate(pickupEffect, Transform.position, transform.rotation);
//		//Turn the Got It Effect on the UI
//
//
//
//
//		//Apply Effect to the player
//		//This needs to get modified to whatever we call the player stats
//
//		PlayerStats stats = player.GetComponent<PlayerStats>();
//		stats.health -= minusBonus;
//
//		GetComponent<MeshRenderer> ().enabled = false;
//		GetComponent<Collider> ().enabled = false;
//
//
//
//		//Remove Power Up
//		Destroy(gameObject);
//	}


}
