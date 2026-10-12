using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array of car names
      string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

      // Sorts the car names alphabetically
      Array.Sort(cars);

      // Prints the sorted array
      foreach (string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}
