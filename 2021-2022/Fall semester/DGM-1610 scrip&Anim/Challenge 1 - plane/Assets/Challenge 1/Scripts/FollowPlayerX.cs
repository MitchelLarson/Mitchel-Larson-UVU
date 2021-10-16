using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject playerX;
    private Vector3 offset = new Vector3(20, 2, 10);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Debug.Log("lateupdatestarted");
        transform.position = playerX.transform.position + offset;
    }
}
