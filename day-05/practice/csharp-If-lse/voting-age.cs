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

      // Checks whether the person can vote
      if (myAge >= votingAge)
      {
        Console.WriteLine("Old enough to vote!");
      }
      else
      {
        Console.WriteLine("Not old enough to vote.");
      }
    }
  }
}
