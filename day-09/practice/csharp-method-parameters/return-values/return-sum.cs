using System;

namespace Day09
{
  class Program
  {
    // Returns the sum of two numbers
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      // Prints the returned sum
      Console.WriteLine(MyMethod(5, 3));
    }
  }
}
