using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player
{
   public string Username;
   public string Number;

   public Player(){}
   public Player(string name, string num){
       Username = name;
       Number = num;

   }
}//class
