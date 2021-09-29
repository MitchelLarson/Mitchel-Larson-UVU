using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comparison : MonoBehaviour
{
    private void Start()
    {
        int x = 3;
        int y = 5;
        Debug.Log(x != y);
        Debug.Log(x > y);
        Debug.Log(x < y);
        Debug.Log(x >= y);
        Debug.Log(x <= y);
        Debug.Log(x == y);
        Debug.Log(x < 5 && x < 10);
        Debug.Log(x < 5 || x< 4);
        Debug.Log(!(x < 5 && x < 10));
    }
}
