using System;

namespace Day09
{
  class Program
  {
    // Returns 5 plus the given number
    static int MyMethod(int x)
    {
      return 5 + x;
    }

    static void Main(string[] args)
    {
      // Prints the returned value
      Console.WriteLine(MyMethod(3));
    }
  }
}
