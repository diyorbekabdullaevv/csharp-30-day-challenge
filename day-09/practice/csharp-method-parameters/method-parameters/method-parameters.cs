using System;

namespace Day09
{
  class Program
  {
    // Accepts a first name as a parameter
    static void MyMethod(string fname)
    {
      Console.WriteLine(fname + " Refsnes");
    }

    static void Main(string[] args)
    {
      // Calls the method with different arguments
      MyMethod("Liam");
      MyMethod("Jenny");
      MyMethod("Anja");
    }
  }
}
