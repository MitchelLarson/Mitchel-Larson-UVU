using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move APC forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //turn of APC
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
    }
}