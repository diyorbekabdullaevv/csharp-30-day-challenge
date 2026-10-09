using System;

namespace Day05
{
  class Program
  {
    static void Main(string[] args)
    {
      // Stores the current hour
      int time = 20;

      // Chooses a greeting based on the condition
      string result = (time < 18) ? "Good day." : "Good evening.";

      // Prints the selected greeting
      Console.WriteLine(result);
    }
  }
}
