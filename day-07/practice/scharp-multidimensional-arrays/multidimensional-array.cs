using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates a two-dimensional array
      int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

      // Prints the number of the first row, third column
      Console.WriteLine(numbers[0, 2]);
    }
  }
}
