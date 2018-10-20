using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public GameObject ship;
    Vector2 dir;

    // Use this for initialization
    void Start()
    {
        dir = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        dir = new Vector2(moveX, moveY);
        dir.Normalize();

        transform.position += moveSpeed * new Vector3(dir.x, dir.y, 0.0f) * Time.deltaTime;

        float angle = Vector2.Angle(dir, Vector2.up);
        if (dir.x > 0)
            angle = -angle;
        ship.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //move along with platform
        if (other.transform.tag == "Collider")
        {
            Debug.Log("Hit something");
        }
    }
}
