using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float moveSpeed = 440;
    float turnSpeed = 20;
    float speedBoost = 540;
    float slowDown = 440;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float turningSpeed = Input.GetAxis("Vertical") * turnSpeed * Time.deltaTime;
        // float steerAmount = Input.GetAxis("Horizontal") * moveSpeed;
        // float turningSpeed = Input.GetAxis("Vertical") * turnSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, turningSpeed, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Slow Down Collision with " + other.gameObject.name);
        moveSpeed = slowDown;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("Boost");
            moveSpeed += speedBoost;
            // Destroy(other.gameObject, 0.5f);
        }
    }
}
