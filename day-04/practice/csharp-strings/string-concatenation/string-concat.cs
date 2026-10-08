using System;

namespace Day04
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates two strings
      string firstName = "Diyorbek ";
      string lastName = "Abdullaev";

      // Combines the strings using string.Concat()
      string name = string.Concat(firstName, lastName);

      // Prints the combined string
      Console.WriteLine(name);
    }
  }
}
