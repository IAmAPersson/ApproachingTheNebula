using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other) {
	        //move along with platform
	        if (other.transform.tag == "Collider") {
		    // Collider2D.collider.gameObject.name 
	            Debug.Log(gameObject.name + " hit " + other.collider.gameObject.name);
	        }
    }	

}
