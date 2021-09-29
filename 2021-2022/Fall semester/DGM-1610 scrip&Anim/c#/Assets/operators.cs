using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operators : MonoBehaviour
{
    private void Start()
    {
        int sum1 = 100 + 50;
        int sum2 = sum1 + 250;
        int sum3 = sum2 + sum2;
        
        Debug.Log(sum1);
        Debug.Log(sum2);
        Debug.Log(sum3);
    }
}
