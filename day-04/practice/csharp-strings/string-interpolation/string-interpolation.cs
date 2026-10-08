using System;

namespace Day04
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creates first and last name variables
      string firstName = "John";
      string lastName = "Doe";

      // Inserts the variables into a string
      string name = $"My full name is: {firstName} {lastName}";

      // Prints the interpolated string
      Console.WriteLine(name);
    }
  }
}
