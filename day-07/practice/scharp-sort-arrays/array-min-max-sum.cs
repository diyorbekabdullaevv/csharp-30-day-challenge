using System;
using System.Linq;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array of integers
      int[] myNumbers = { 5, 1, 8, 9 };

      // Prints the largest value
      Console.WriteLine(myNumbers.Max());

      // Prints the smallest value
      Console.WriteLine(myNumbers.Min());

      // Prints the sum of all values
      Console.WriteLine(myNumbers.Sum());
    }
  }
}
