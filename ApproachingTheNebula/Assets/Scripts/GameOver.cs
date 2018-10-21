using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	Text resultsTextField;
	BackgroundScroller bgScroller;

	// Use this for initialization
	void Start () {
		Camera camera = Camera.allCameras[0];
		GameObject[] rootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
		
		for ( int i = 0; i < rootObjects.Length; i++ ) {
			if(rootObjects[i].name == "background") {
				bgScroller = rootObjects[i].GetComponent<BackgroundScroller>();
				break;
			}
		}
		Text[] textFields = camera.GetComponentsInChildren<Text>();
		for (int i = 0; i < textFields.Length; i++ ) {
			if (textFields[i].name == "Results") {
				resultsTextField = textFields[i];
				break;
			}
		}
		Debug.Log(resultsTextField.name);
		// bgScroller = 
	}
	
	// Update is called once per frame
	void Update () {
		 if ( resultsTextField.text.Length > 0 ) {
			bgScroller.speed = 0;
			if ( Input.GetKeyDown(KeyCode.R) ) {
				Debug.Log("Restarting Level");
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}
	}
}
