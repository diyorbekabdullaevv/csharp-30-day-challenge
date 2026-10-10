using System;

namespace Day06
{
  class Program
  {
    static void Main(string[] args)
    {
      // Stores four car names in an array
      string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

      // Goes through each car in the array
      foreach (string car in cars)
      {
        // Prints the current car name
        Console.WriteLine(car);
      }
    }
  }
}
