using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array with four elements
      string[] cars = new string[4];

      // Assigns values to the elements
      cars[0] = "Volvo";
      cars[1] = "BMW";
      cars[2] = "Ford";
      cars[3] = "Mazda";

      // Prints the array elements
      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}
