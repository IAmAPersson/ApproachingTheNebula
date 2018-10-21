using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSpeed : MonoBehaviour
{
    const double init = 48.5, fin = -55.5;
    double distance;
    bool passedTheStart;
    Text resultsTextField;


    // Use this for initialization
    void Start ()
    {
        var txt = gameObject.GetComponent<Text>();
        txt.text = "Speed: 0c\nTime remaining: 3d";
	Text[] textFields = Camera.allCameras[0].GetComponentsInChildren<Text>();
	for (int i = 0; i < textFields.Length; i++ ) {
		if (textFields[i].name == "Results") {
			resultsTextField = textFields[i];
			break;
		}
	}
	passedTheStart = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        var txt = gameObject.GetComponent<Text>();
        var speed = FindObjectOfType<BackgroundScroller>();
        double current = speed.xposition;
        distance = Math.Abs((speed.speed != 0) ? Math.Truncate((1344.0 * (fin - current)) / (Convert.ToDouble(PercentC(speed.speed)) * (fin - init))) : 0);
        int temp = 0;
        try { temp = Convert.ToInt32(55 * (distance / 1344) - 30); } catch { }; //I'm sorry gods of good practice
        txt.text = "S P E E D: " + PercentC(speed.speed) + "c" + Environment.NewLine +
                   "T E M P E R A T U R E: " + temp + " C" + Environment.NewLine +
                   "D I S T A N C E  T O  O R I O N: " + distance + "ly";
	if ( distance == 0 && passedTheStart ) {
		resultsTextField.text = "Orion Has Been Reached.\nPress [R] to restart.";
	}
	passedTheStart = true;
    }

    private static string PercentC(float speed)
    {
        double nines = 16.0 / 5.0 * speed + 0.001;
        return "0." + Times("9", Convert.ToInt32(Math.Truncate(nines))) + Convert.ToInt32((nines - Math.Truncate(nines)) * 100);
    }

    private static string Times(string L, int R)
    {
        string returnvalue = "";
        for (int i = 1; i <= R; i++)
            returnvalue += L;
        return returnvalue;
    }
}
