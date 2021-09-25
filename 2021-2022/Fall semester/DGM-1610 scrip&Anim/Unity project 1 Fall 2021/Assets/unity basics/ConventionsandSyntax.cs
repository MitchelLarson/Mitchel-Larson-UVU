using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
        void Start()
        {
                //this line is there to tell me the x postion of my object
                
                /*hi there!
                 * this is two lines!
                 * */
                Debug.Log(transform.position.x);

                if (transform.position.y <= 5f)
                {
                    Debug.Log ("I'm about to hit the ground!");
                }
        }
}
