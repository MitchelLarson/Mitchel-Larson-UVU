using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHifelse : MonoBehaviour
{
  private void Start()
  {
    int time = 20;
    if (time < 18)
    {
      Debug.Log("good day.");
    }
    else
    {
      Debug.Log("good evening.");
    }
  }
}
