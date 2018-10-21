using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {


    public float speed;
    Vector3 startPosition;
    bool beginning = true;

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (speed < 5 && beginning)
            speed += 0.02f;
        else
            beginning = false;
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
        if (transform.position.x < -45 && speed > 0)
            speed -= 0.02f;
        if (speed < 0)
            speed = 0;

	}
}
