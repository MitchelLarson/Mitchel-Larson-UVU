using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultword : MonoBehaviour
{
    private void Start()
    {
        int day = 4;
        switch (day) 
        {
            case 6:
                Debug.Log("Today is Saturday.");
                break;
            case 7:
                Debug.Log("Today is Sunday.");
                break;
            default:
                Debug.Log("Looking forward to the Weekend.");
                break;
        }
    }
}
