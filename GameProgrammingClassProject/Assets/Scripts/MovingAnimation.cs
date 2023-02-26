using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAnimation : MonoBehaviour
{
    private Animator animator;
    private bool isMoving;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            if (!isMoving)
            {
                animator.SetTrigger("Walking");
                isMoving = true;
            }
            transform.Translate(horizontalInput * Time.deltaTime, 0, 0);
        }
        else
        {
            if (isMoving)
            {
                animator.SetTrigger("Walking");
                isMoving = false;
            }
        }
    }
}
