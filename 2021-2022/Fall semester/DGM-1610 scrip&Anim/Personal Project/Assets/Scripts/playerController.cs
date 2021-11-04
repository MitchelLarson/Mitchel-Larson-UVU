using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerController : MonoBehaviour
{   public float speed = 10.0f;
    private float xBound = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//move player object left and right with the press of key "A" and "D".
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        } 
        //restrict player in the walls no more than x = 10 and x = -10.
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, 0, 0);
        }
        if (transform.position.x > xBound)
        { 
            transform.position = new Vector3(xBound, 0, 0);
        }
    }
   
}
