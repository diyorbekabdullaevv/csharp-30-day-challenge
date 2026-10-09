using System;

namespace Day05
{
  class Program
  {
    static void Main(string[] args)
    {
      // Stores the current hour
      int time = 22;

      // Checks which greeting matches the time
      if (time < 10)
      {
        Console.WriteLine("Good morning.");
      }
      else if (time < 20)
      {
        Console.WriteLine("Good day.");
      }
      else
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}
