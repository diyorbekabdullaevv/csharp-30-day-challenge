using System;

namespace Day09
{
  class Program
  {
    // Accepts three child names
    static void MyMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
      // Passes arguments by parameter name
      MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }
  }
}
