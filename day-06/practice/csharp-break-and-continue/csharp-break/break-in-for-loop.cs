using System;

namespace Day06
{
  class Program
  {
    static void Main(string[] args)
    {
      // Loops from 0 to 9
      for (int i = 0; i < 10; i++)
      {
        // Stops the loop when i equals 4
        if (i == 4)
        {
          break;
        }

        // Prints the current value before the loop stops
        Console.WriteLine(i);
      }
    }
  }
}
