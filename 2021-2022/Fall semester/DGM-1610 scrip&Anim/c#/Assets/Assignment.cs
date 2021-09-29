using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    private void Start()
    {
        int x = 5;
        x += 3;
        x -= 3;
        x *= 3;
        x /= 3;
        x %= 3;
        x &= 3;
        x |= 3;
        x ^= 3;
        x >>= 3;
        x <<= 3;
        x = x + 3;
        x = x - 3;
        x = x * 3;
        x = x / 3;
        x = x % 3;
        x = x & 3;
        x = x | 3;
        x = x ^ 3;
        x = x >> 3;
        x = x << 3;


        Debug.Log(x);
        
    }
}
