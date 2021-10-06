using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraysthree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        for (int i = 0; i < cars.Length; i++) 
        {
            Debug.Log(cars[i]);
        }   
    }
}
