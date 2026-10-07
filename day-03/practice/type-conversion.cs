using System;

namespace Day03
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates variables with different data types
      int myInt = 10;
      double myDouble = 5.25;
      bool myBool = true;

      // Converts int to string
      Console.WriteLine(Convert.ToString(myInt));

      // Converts int to double
      Console.WriteLine(Convert.ToDouble(myInt));

      // Converts double to int
      Console.WriteLine(Convert.ToInt32(myDouble));

      // Converts bool to string
      Console.WriteLine(Convert.ToString(myBool));
    }
  }
}
