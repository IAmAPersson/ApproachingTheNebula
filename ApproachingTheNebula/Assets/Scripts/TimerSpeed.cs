using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSpeed : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
        var txt = gameObject.GetComponent<Text>();
        txt.text = "Speed: 0c\nTime remaining: 3d";
    }
	
	// Update is called once per frame
	void Update ()
    {
        var txt = gameObject.GetComponent<Text>();
        var speed = FindObjectOfType<BackgroundScroller>();
        txt.text = "S P E E D: " + PercentC(speed.speed) + Environment.NewLine +
                   "T E M P E R A T U R E: " + "25 C" + Environment.NewLine +
                   "D I S T A N C E  T O  O R I O N: " + 1344 + "ly";
    }

    private static string PercentC(float speed)
    {
        double nines = 16.0 / 5.0 * speed + 0.001;
        return "0." + Times("9", Convert.ToInt32(Math.Truncate(nines))) + Convert.ToInt32((nines - Math.Truncate(nines)) * 100) + "c";
    }

    private static string Times(string L, int R)
    {
        string returnvalue = "";
        for (int i = 1; i <= R; i++)
            returnvalue += L;
        return returnvalue;
    }
}
