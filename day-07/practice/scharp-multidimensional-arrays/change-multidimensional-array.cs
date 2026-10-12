using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates a two-dimensional array
      int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

      // Changes the first element to 5
      numbers[0, 0] = 5;

      // Prints the updated element
      Console.WriteLine(numbers[0, 0]);
    }
  }
}
