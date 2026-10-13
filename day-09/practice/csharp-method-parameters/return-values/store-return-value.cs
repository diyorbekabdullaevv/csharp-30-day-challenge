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
      // Stores the returned sum in a variable
      int z = MyMethod(5, 3);

      // Prints the result
      Console.WriteLine(z);
    }
  }
}
