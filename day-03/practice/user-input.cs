using System;

namespace Day03
{
  class Program
  {
    static void Main(string[] args)
    {
      // Asks the user to enter their username
      Console.WriteLine("Enter username:");

      // Reads and stores the user's input
      string userName = Console.ReadLine();

      // Prints the username
      Console.WriteLine("Username is: " + userName);
    }
  }
}
