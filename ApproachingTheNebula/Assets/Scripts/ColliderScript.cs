using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderScript : MonoBehaviour {

	private Text resultsTextField;

	// Use this for initialization
	void Start () {
		resultsTextField = Camera.main.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D other) {
	        //move along with platform
	        if (other.transform.tag == "Collider") {
		    // Collider2D.collider.gameObject.name 
	            Debug.Log(gameObject.name + " hit " + other.collider.gameObject.name);
		    if ( gameObject.name == "ship" || gameObject.name == "tether" || gameObject.name == "Dyson" ) {
			// If we hit the ship, set the Results text to losing.
			resultsTextField.text = "Orion Has Not Been Reached\nPress [R] to try again.";
		    }
	        }
    }	

}
