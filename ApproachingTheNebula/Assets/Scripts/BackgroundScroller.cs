using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {


    public float speed;
    Vector3 startPosition;
    bool beginning = true;
    public double xposition;
    public bool completed;

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        xposition = transform.position.x;
        if (speed < 5 && beginning)
            speed += 0.02f;
        else
            beginning = false;
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
        if (xposition < -45 && speed > 0)
            speed -= 0.05f;
        if (speed < 0)
        {
            speed = 0;
            completed = true;
        }

	}
}
