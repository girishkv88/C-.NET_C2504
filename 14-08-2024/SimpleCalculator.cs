using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.cs
{
  class Calculator
  {
      private double _numOne;
      private double _numTwo;
  
      private void Add() => Console.WriteLine($"{_numOne} + {_numTwo} = {_numOne + _numTwo}");
      private void Sub() => Console.WriteLine($"{_numOne} - {_numTwo} = {_numOne - _numTwo}");
      private void Mul() => Console.WriteLine($"{_numOne} * {_numTwo} = {_numOne * _numTwo}");
      private void Div() => Console.WriteLine($"{_numOne} / {_numTwo} = {_numOne / _numTwo}");
      public void Run()
      {
          while (true)
          {
              Console.Write("Num 1: ");
              _numOne = double.Parse(Console.ReadLine());
              Console.Write("Num 2: ");
              _numTwo = double.Parse(Console.ReadLine());
  
              Add();
              Sub();
              Mul();
              Div();
  
              Console.WriteLine("Press any key to continue");
              Console.ReadKey();
              Console.Clear();
          }
      }
  }
  internal class Program
          {
              static void Main(string[] args)
              {
                 new Calculator.Run()
                
  
              }
          }
}
