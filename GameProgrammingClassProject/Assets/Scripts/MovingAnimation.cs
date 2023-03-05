using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAnimation : MonoBehaviour
{
    public string objectTag = "Player"; // The tag of the game object to move
    public float moveSpeed = 5.0f; // The speed at which to move the game object horizontally

    void Start()
    {
    }

    private void Update()
    {
        if (this.gameObject.tag == objectTag)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");

            float horizontalMovement = horizontalInput * moveSpeed * Time.deltaTime;

            this.gameObject.transform.Translate(horizontalMovement, 0, 0);
        }
    }


    //Set animator parameters anim.SetBool ("run", horizontal Input = 0);
    // private Animator animator;
    // private bool isMoving;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     animator = GetComponent<Animator>();
    //     isMoving = false;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Player");

    //     foreach (GameObject obj in objectsWithTag)
    //     {
    //         Vector3 position = obj.transform.position;
    //         position.x += 5.0f * Time.deltaTime;
    //         obj.transform.position = position;
    //     }
    // }

}
