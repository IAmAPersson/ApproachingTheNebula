using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {


    public float speed;
    Vector3 startPosition;

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (speed < 5)
            speed += 0.05f;
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
	}
}
