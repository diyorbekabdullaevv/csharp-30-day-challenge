using System;

namespace Day06
{
  class Program
  {
    static void Main(string[] args)
    {
      // Outer loop runs 2 times
      for (int i = 1; i <= 2; i++)
      {
        // Prints the outer loop value
        Console.WriteLine("Outer: " + i);

        // Inner loop runs 3 times for each outer iteration
        for (int j = 1; j <= 3; j++)
        {
          // Prints the inner loop value
          Console.WriteLine("Inner: " + j);
        }
      }
    }
  }
}
