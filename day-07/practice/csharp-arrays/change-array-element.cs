using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array of car names
      string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

      // Changes the first element
      cars[0] = "Opel";

      // Prints the updated element
      Console.WriteLine(cars[0]);
    }
  }
}
