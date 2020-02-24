using System;

class Sphinx
{

  static void Main()
  {
    Console.WriteLine("Riddles of the Sphinx. Enter the answer below to defeat the Sphinx:");
    Question();
  }

  //   static void getResponse()
  // {
  //   string inputResponse = Console.ReadLine();
  //   string response = inputResponse.ToLower();
  // }

  static void Question()
  {
    var rand = new Random();
    var riddleNumber = rand.Next(1, 6);
    Console.WriteLine(riddleNumber);

    if (riddleNumber == 1)
    {
      Console.WriteLine("During which month do people sleep the least?");
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response == "february")
      {
        Console.WriteLine("That is correct.");
        Question();
      }
      else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
    else if (riddleNumber == 2)
    {
      Console.WriteLine("What can travel around the world while staying in a corner?");
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response.Contains("stamp") == true)
      {
        Console.WriteLine("That is correct.");
        Question();
      }
      else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
    else if (riddleNumber == 3)
    {
      Console.WriteLine("What has a head and a tail, but no body?");
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response.Contains("coin") == true)
      {
        Console.WriteLine("That is correct.");
        Question();
      }
      else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
    else if (riddleNumber == 4)
    {
      Console.WriteLine("What gets wetter and wetter the more it dries?");
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response.Contains("towel") == true)
      {
        Console.WriteLine("That is correct.");
        Question();
      }
      else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
    else  if (riddleNumber == 5)
    {
      Console.WriteLine("Paul's height is six feet, he's an assistant at a butcher's shop, and wears size 9 shoes. What does he weigh?");
      string inputResponse = Console.ReadLine();
      string response = inputResponse.ToLower();
      if (response.Contains("meat") == true)
      {
        Console.WriteLine("That is correct.");
        Question();
      }
      else
      {
        Console.WriteLine("Wrong! The Sphinx devours you.");
      }
    }
    else
    {
      Console.WriteLine("Riddle number is empty");
    }
  }
} 