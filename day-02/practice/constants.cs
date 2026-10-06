using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates a constant integer
      const int myNum = 15;

      // This would cause an error because constants cannot be changed
      // myNum = 20;

      // Prints the constant value
      Console.WriteLine(myNum);
    }
  }
}
