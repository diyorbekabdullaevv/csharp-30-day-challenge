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
        // Skips the iteration when i equals 4
        if (i == 4)
        {
          continue;
        }

        // Prints the value unless it is 4
        Console.WriteLine(i);
      }
    }
  }
}
