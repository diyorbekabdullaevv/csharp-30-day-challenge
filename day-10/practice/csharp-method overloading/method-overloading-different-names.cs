using System;

namespace Day10
{
  class Program
  {
    // Adds two integers
    static int PlusMethodInt(int x, int y)
    {
      return x + y;
    }

    // Adds two double values
    static double PlusMethodDouble(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      // Calls each method with different data types
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);

      // Prints both results
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }
  }
}
