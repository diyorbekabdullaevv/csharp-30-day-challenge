using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array without specifying its size
      string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

      // Prints the array elements
      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}
