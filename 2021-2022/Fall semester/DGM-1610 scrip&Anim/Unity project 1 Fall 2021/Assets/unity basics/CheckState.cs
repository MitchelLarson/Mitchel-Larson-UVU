using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myObject;

    void Start()
    {
        Debug.Log("active Self: " + myObject.activeSelf);
        Debug.Log("active in Hierarchy" + myObject.activeInHierarchy);
    }
}
