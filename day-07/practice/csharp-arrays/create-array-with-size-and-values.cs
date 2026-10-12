using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array with four elements and values
      string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

      // Prints the array elements
      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}
