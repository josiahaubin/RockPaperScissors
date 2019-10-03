using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //NOTE creating a random number between 1-3
      Random rand = new Random();
      int compNum = rand.Next(1, 4);

      string compChoice;


      bool running = true;

      while (running)
      {
        //NOTE converting number to rock,paper,scissors
        if (compNum == 1)
        {
          compChoice = "rock";
        }
        else if (compNum == 2)
        {
          compChoice = "paper";
        }
        else
        {
          compChoice = "scissors";
        }
        try
        {
          Console.WriteLine("Please pick Rock, Paper, or Scissors.");
          string userAns = Console.ReadLine().ToLower();
          //NOTE check user answer
          if (userAns != "rock" && userAns != "paper" && userAns != "scissors")
          {
            throw new Exception();
          }

          // NOTE Case computer picks rock
          if (userAns == "rock" && compChoice == "rock")
          {
            Console.WriteLine($"You both chose {userAns}, so its a tie.");
          }
          else if (userAns == "paper" && compChoice == "rock")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you win.");
          }
          else if (userAns == "scissors" && compChoice == "rock")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you lose.");
          }

          // NOTE Case computer picks paper
          else if (userAns == "paper" && compChoice == "paper")
          {
            Console.WriteLine($"You both chose {userAns}, so its a tie.");
          }
          else if (userAns == "rock" && compChoice == "paper")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you lose.");
          }
          else if (userAns == "scissors" && compChoice == "paper")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you win.");
          }
          // NOTE Case computer picks scissors
          else if (userAns == "scissors" && compChoice == "scissors")
          {
            Console.WriteLine($"You both chose {userAns}, so its a tie.");
          }
          else if (userAns == "paper" && compChoice == "scissors")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you lose.");
          }
          else if (userAns == "rock" && compChoice == "scissors")
          {
            Console.WriteLine($"You chose {userAns} and the computer chose {compChoice} so you win.");
          }

          //NOTE see if user wants to play again
          Console.WriteLine("Do you want to play again? y/n");
          string playAgain = Console.ReadLine().ToLower();

          switch (playAgain)
          {
            case "y":
              compNum = rand.Next(1, 4);
              break;

            case "n":
              running = false;
              Console.Clear();
              Console.WriteLine("Thanks for playing!");
              break;
          }
        }
        catch (Exception)
        {
          Console.WriteLine("No cheating");
        }
      }
    }
  }
}
