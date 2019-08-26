using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : Sign
{
   public void TurnOffSign() {
       id = "";
       verticalLine.color = new Color(0,0,0,0);
       horizontalLine.color = new Color(0,0,0,0);
       crossLine.color = new Color(0,0,0,0);
       graetCircle.color = new Color(0,0,0,0);
       smallCircle.color = new Color(0,0,0,0);
       greatSquare.color = new Color(0,0,0,0);
       smallSquare.color = new Color(0,0,0,0);
   }

   void Start() {
       TurnOffSign();
   }

   public void DrawInSlot(string identificator) {
       id = identificator;
       CreateSign(id);
   }
}
