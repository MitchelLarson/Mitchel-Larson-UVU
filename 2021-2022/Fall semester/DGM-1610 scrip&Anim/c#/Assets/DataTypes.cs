using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypes : MonoBehaviour
{
    private void Start()
    {
        int myNum = 5;
        double mydoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";
        Debug.Log(myNum);
        Debug.Log(mydoubleNum);
        Debug.Log(myLetter);
        Debug.Log(myBool);
        Debug.Log(myText);
    }
}
