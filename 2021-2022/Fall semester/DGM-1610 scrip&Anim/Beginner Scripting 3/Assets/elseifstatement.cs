using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elseifstatement : MonoBehaviour
{
   private void Start()
   {
      int time = 22;
      if (time < 10)
      {
         Debug.Log("Good morning");
      }
      else if (time < 20)
      {
         Debug.Log("Good day.");
      }
      else
      {
       Debug.Log("good evening.");  
      }
   }
}
