using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forlooptwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i = i + 2)
        {
            Debug.Log(i);
        }   
    }
}
