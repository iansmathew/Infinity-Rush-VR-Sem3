using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    
    public int speedMult = 1;
    public int warpSpeed = 50;
    public float zLocate;
    public int health = 100;

    [Header("Audio Components")]
    [SerializeField]
    private AudioClip onHitClip;
    [SerializeField]
    private AudioClip onDestroyClip;
    [SerializeField]
    private AudioClip onPlayerHitClip;
    private AudioSource audioSource;


    // Use this for initialization
    void Start () {

        audioSource = GameObject.Find("EnemySpawnManager").GetComponent<AudioSource>();

        Quaternion.Euler(0,-90,0);
    }
	
	// Update is called once per frame
	void Update () {
        float distShift;
        //transform.LookAt(shipTarget.transform);
        if (transform.position.z >= 50)
            distShift = Mathf.Sqrt(transform.position.z);
        else
            distShift = 0.1f;
        if (transform.position.z <= 100)
            warpSpeed = 1;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (distShift));
        if (transform.position.z <= -10)
        {
            //Play player hit sound
            audioSource.PlayOneShot(onPlayerHitClip);

            HUDScript.Instance.UpdatePlayerHealth(10); //Player takes damage; 
            Destroy(gameObject);
        }

	}

    public void TakeHit(int damage)
    {
        //Play hit sound
        //audioSource.PlayOneShot(onHitClip);

        //TODO: Mattthew - Spawn destroyed particles
        health -= damage;
        if(health <= 0)
        {
            //Play destroy sound
            audioSource.PlayOneShot(onDestroyClip);

            HUDScript.Instance.UpdateScore(10);
            Destroy(gameObject);
        }
    }
}

