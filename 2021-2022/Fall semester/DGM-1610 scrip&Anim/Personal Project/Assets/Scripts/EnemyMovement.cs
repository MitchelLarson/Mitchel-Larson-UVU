using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody objectRb;

    private float zDestry = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zDestry)
        {
            Destroy(gameObject);
        }
    }
}
