using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floats : MonoBehaviour
{
   private void Start()
   {
      float myNum = 5.75F;
      Debug.Log(myNum);

      double myNum2 = 19.99D;
      Debug.Log(myNum2);

      float f1 = 35e3F;
      double d1 = 12E4D;
      Debug.Log(f1);
      Debug.Log(d1);
   }
}
