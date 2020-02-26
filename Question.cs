using System;

namespace Sphinx.Models
{

  public class Riddles
  {
    public static int GetRandomNumber()
    {
      var rand = new Random();
      var riddleNumber = rand.Next(1, 6);
      return riddleNumber;
    }

    public static void Question(int riddleNumber)
    {

      string[] questionArr = { "During which month do people sleep the least?", "What can travel around the world while staying in a corner?", "What has a head and a tail, but no body?", "What gets wetter and wetter the more it dries?", "Paul's height is six feet, he's an assistant at a butcher's shop, and wears size 9 shoes. What does he weigh?" };

      string[] answersArr = { "february", "stamp", "coin", "towel", "meat" };
     

      Console.WriteLine(questionArr[riddleNumber]);
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response == answersArr[riddleNumber])
      {
        Console.WriteLine("That is correct.");
      }
        else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
  }
}