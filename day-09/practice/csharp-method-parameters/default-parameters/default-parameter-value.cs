using System;

namespace Day09
{
  class Program
  {
    // Uses Norway as the default country
    static void MyMethod(string country = "Norway")
    {
      Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
      // Calls the method with and without an argument
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}
