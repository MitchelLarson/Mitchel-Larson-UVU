using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proprotation : MonoBehaviour
{
    public float propspeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propspeed);
    }
}
