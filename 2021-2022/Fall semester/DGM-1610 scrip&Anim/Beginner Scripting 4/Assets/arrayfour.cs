using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayfour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        foreach (string i in cars) 
        {
            Debug.Log(i);
        }   
    }
}
