using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	Text resultsTextField;

	// Use this for initialization
	void Start () {
		Text[] textFields = Camera.allCameras[0].GetComponentsInChildren<Text>();
		for (int i = 0; i < textFields.Length; i++ ) {
			if (textFields[i].name == "Results") {
				resultsTextField = textFields[i];
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ( resultsTextField.text.Length > 0 ) {
			if ( Input.GetKeyDown(KeyCode.R) ) {
				Debug.Log("Restarting Level");
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}
	}
}
