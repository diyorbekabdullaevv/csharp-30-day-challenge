using System;

namespace Day06
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starts the counter at 0
      int i = 0;

      // Repeats while i is less than 10
      while (i < 10)
      {
        // Prints the current value
        Console.WriteLine(i);

        // Increases the counter by 1
        i++;

        // Stops the loop when i reaches 4
        if (i == 4)
        {
          break;
        }
      }
    }
  }
}
