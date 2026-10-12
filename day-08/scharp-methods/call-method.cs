using System;

namespace Day08
{
  class Program
  {
    static void MyMethod()
    {
      // Prints a message when the method is called
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      // Calls the method three times
      MyMethod();
      MyMethod();
      MyMethod();
    }
  }
}
