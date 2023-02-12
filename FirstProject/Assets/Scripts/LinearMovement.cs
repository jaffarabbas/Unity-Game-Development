using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float upSpeed = 20.0f;
    public float reset = 0.0f;
    public float v = -10.97f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void resetGame()
    {
        transform.position = Vector3.right * reset;
        transform.position += Vector3.right * v;
    }
    void go()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    void goUpAndDown()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * upSpeed * Time.deltaTime; 
            transform.position += Vector3.up * reset;
        }
    }
    // Update is called once per frame
    void Update()
    {
        go();
        if (transform.position.x > 10.0)
        {
            resetGame();
            go();
        }
        goUpAndDown();
    }
}
