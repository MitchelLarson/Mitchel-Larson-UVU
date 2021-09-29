using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arithmetic : MonoBehaviour
{
    private void Start()
    {
        int x = 3;
        int y = 5;
                Debug.Log(x + y);
                Debug.Log(x - y);
                Debug.Log(x * y);
                Debug.Log(x / y);
                Debug.Log(x % y);
                Debug.Log(x++);
                Debug.Log(x--);
    }
}
