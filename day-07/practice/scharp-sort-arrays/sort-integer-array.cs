using System;

namespace Day07
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates an array of integers
      int[] myNumbers = { 5, 1, 8, 9 };

      // Sorts the numbers in ascending order
      Array.Sort(myNumbers);

      // Prints the sorted numbers
      foreach (int number in myNumbers)
      {
        Console.WriteLine(number);
      }
    }
  }
}
