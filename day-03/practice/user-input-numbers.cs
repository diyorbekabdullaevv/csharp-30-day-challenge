using System;

namespace Day03
{
  class Program
  {
    static void Main(string[] args)
    {
      // Asks the user to enter their age
      Console.WriteLine("Enter your age:");

      // Reads the input and converts it from string to int
      int age = Convert.ToInt32(Console.ReadLine());

      // Prints the user's age
      Console.WriteLine("Your age is: " + age);
    }
  }
}
