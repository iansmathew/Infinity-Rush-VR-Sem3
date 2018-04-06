using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    float rotX, rotY, rotZ;
    public int warpSpeed = 50;
    public float zLocate, speedMult;
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
    void Start()
    {
        speedMult = Random.Range(0.1f, 0.135f);
        audioSource = GameObject.Find("EnemySpawnManager").GetComponent<AudioSource>();
        rotX = Random.Range(-10.0f, 10.0f);
        rotY = Random.Range(-10, 10);
        rotZ = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speedMult);
        transform.Rotate(rotX*Time.deltaTime, rotY * Time.deltaTime, rotZ * Time.deltaTime,0);
        if (transform.position.z <= -10)
        {
            //Play player hit sound
            audioSource.PlayOneShot(onPlayerHitClip);

            //Asteroid does not do damage to player
            Destroy(gameObject);
        }

    }

    public void TakeHit(int damage)
    {
        //Play hit sound
        //audioSource.PlayOneShot(onHitClip);

        //TODO: Mattthew - Spawn destroyed particles
        health -= damage;
        if (health <= 0)
        {
            //Play destroy sound
            audioSource.PlayOneShot(onDestroyClip);

            HUDScript.Instance.AddPlayerFuel(20);
            Destroy(gameObject);
        }
    }
}

