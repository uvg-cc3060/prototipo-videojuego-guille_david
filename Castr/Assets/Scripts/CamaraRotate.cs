using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraRotate : MonoBehaviour
{
    public float speedV = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotY = Input.GetAxis("Mouse Y") * speedV * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.right, rotY);
    }
}
