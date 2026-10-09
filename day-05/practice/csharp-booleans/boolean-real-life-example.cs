using System;

namespace Day05
{
  class Program
  {
    static void Main(string[] args)
    {
      // Stores the person's age and voting age
      int myAge = 25;
      int votingAge = 18;

      // Checks if the person is old enough to vote
      Console.WriteLine(myAge >= votingAge);
    }
  }
}
