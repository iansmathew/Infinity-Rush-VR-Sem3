using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    
    public int speedMult;
	// Use this for initialization
	void Start () {
        //Debug.Log("Speed: "+speedMult);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f * (1 + speedMult / 3), transform.position.z );
        if (transform.position.y <= GameObject.Find("Cockpit").transform.position.y)
        {
            Destroy(gameObject);
            //Player takes damage; 
        }

	}
}
