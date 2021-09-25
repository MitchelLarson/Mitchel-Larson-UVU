using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
   public int intelligece = 5;

   void Greet()
   {
      switch (intelligece)
      {
         case 5:
            print("Good evening sir! Hows about a game of shuffle board?");
            break;
         case 4:
            print("Hello good sir!");
            break;
         case 3:
            print("hello there");
            break;
         case 2:
            print("watcha doing here?");
            break;
         case 1:
            print("WHHAAAAAAAGGGGGG!!!!");
            break;
         default:
            print("incorrect intelligence level,");
            break;
      }
   }
}
