using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 10.0f;
    public float speedV = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);
        transform.Translate(0f, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        float rotX = Input.GetAxis("Mouse X") * speedV * Mathf.Deg2Rad;
        transform.RotateAround(Vector3.up, rotX);
    }

}
