using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemySetEventOnRuntime : MonoBehaviour {

    EventTrigger trigger;
    
	// Use this for initialization
	void Start () {
        trigger = GetComponent<EventTrigger>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
