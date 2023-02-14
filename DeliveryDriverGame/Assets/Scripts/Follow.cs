using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject targetObject;
    // Update is called once per frame
    void Update()
    {
        transform.position = targetObject.transform.position + new Vector3(0, 0, -10);
    }
}
