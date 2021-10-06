using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dowhileloop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        do
        {
            Debug.Log(i);
            i++;
        } while (i < 5);
    }
}
