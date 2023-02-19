using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classWork : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * 5, body.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, 10);
        }
    }
}
