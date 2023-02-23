using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool isPackageDelivered = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision with " + other.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !isPackageDelivered)
        {
            Debug.Log("Package collected");
            isPackageDelivered = true;
            Destroy(other.gameObject, 0.5f);
        }
        if (other.tag == "Customer" && isPackageDelivered)
        {
            Debug.Log("Package delivered");
            isPackageDelivered = false;
        }
    }
}
