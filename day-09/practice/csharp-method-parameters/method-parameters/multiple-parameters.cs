using System;

namespace Day09
{
  class Program
  {
    // Accepts a name and an age
    static void MyMethod(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
      // Passes two arguments to the method
      MyMethod("Liam", 5);
      MyMethod("Jenny", 8);
      MyMethod("Anja", 31);
    }
  }
}
