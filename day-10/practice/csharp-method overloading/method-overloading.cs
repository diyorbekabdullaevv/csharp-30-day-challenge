using System;

namespace Day10
{
  class Program
  {
    // Adds two integers
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    // Adds two double values
    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      // Calls the matching method based on argument types
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);

      // Prints both results
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }
  }
}
