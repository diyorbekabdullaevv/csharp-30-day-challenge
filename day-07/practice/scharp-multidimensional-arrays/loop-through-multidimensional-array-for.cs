using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates a two-dimensional array
      int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

      // Loops through each row
      for (int i = 0; i < numbers.GetLength(0); i++)
      {
        // Loops through each column
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          // Prints the current element
          Console.WriteLine(numbers[i, j]);
        }
      }
    }
  }
}
