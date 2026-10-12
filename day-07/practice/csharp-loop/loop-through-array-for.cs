using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array of car names
      string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

      // Loops through the array using its length
      for (int i = 0; i < cars.Length; i++)
      {
        Console.WriteLine(cars[i]);
      }
    }
  }
}
