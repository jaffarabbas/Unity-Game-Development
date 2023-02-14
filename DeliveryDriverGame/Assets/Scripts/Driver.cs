using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float moveSpeed = 440;
    float turnSpeed = 20;
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
}
