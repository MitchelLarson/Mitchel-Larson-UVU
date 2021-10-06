using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int I = 0;
       while (I < 5)
       {
           Debug.Log(I);
           I++;
       }
    }

   
}
