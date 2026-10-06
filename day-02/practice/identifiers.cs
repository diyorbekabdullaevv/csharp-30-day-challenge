using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Good: descriptive variable name
      int minutesPerHour = 60;

      // Valid, but less descriptive
      int m = 60;

      // Prints both values
      Console.WriteLine(minutesPerHour);
      Console.WriteLine(m);
    }
  }
}
