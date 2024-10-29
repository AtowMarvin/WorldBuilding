using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
   [SerializeField] public int number1;
   [SerializeField] public int number2;
   private enum Operation
   {
      Plus, Minus, Multiply, divide
   }

   [SerializeField] private Operation operation;
   private void Start()
   {
      Debug.Log("n1 + n2 = " +  (number1  + number2));
      Debug.Log("n1 / n2 = " +  Mathf.RoundToInt((float)number1  / number2));
      Debug.Log(operation.ToString() + " " + CalculateNumber(number1, number2).ToString("F2"));
   }

   float CalculateNumber(int n1, int n2)
   {
      //switchingwith switch/case
      switch (operation)
      {
         case Operation.Plus:
            return n1 + n2;
         case Operation.Minus:
            return n1 - n2;
         case Operation.divide:
            return (float) n1 / n2;
         default:
            return n1 * n2;
         
      }
      
      
      //switching with if
   }
}
