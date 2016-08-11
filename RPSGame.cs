using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class RPSGame
    {
        Player playerOne;
        Player playerTwo;
        string one = "rock";
        string two = "paper";
        string three = "scissors";
        int round;
        int numberOfRounds;

        public RPSGame()
        {
            Console.WriteLine("What is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("Your opponents' name is? \nIf you want to play against computer, type in 'computer'.");
            this.playerTwo = new Player(Console.ReadLine());
            this.round = 0;
            this.numberOfRounds = 4;
        }
        public string randomAnswer()
        {
            Random number = new Random();
            int answer = number.Next(1, 4);
            switch (answer)
            {
                case 1:
                    return one;
                case 2:
                    return two;
                default:
                    return three;
            }
        }
        public void startGame()
        {
            while (round <= numberOfRounds)
            {
                Console.WriteLine("Welcome to my Rock Paper Scissors Game!");
                Console.WriteLine("Score is: {0} to {1} with practice round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                Console.WriteLine("Pick your choice: rock, paper or scissors {0}?", playerOne.getName());
                playerOne.setChoice(Console.ReadLine());
                if (playerTwo.getName() == "computer")
                {
                    playerTwo.setChoice(randomAnswer());
                    this.round += 1;
                }
                else
                {
                    Console.WriteLine("{0}, do you choose ROCK, PAPER, or SCISSORS?", playerTwo.getName());
                    playerTwo.setChoice(Console.ReadLine());
                }
                if (playerOne.getChoice() == one && playerTwo.getChoice() == two)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), one, playerTwo.getName(), two);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerTwo.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == two && playerTwo.getChoice() == one)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), two, playerTwo.getName(), one);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == three && playerTwo.getChoice() == two)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), three, playerTwo.getName(), two);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == one && playerTwo.getChoice() == three)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), one, playerTwo.getName(), three);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == three && playerTwo.getChoice() == one)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), three, playerTwo.getName(), one);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == playerTwo.getChoice())
                {
                    Console.WriteLine("It's a TIE");
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    this.round += 1;
                }
                else if (playerOne.getChoice() == two && playerTwo.getChoice() == three)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), two, playerTwo.getName(), three);
                    Console.WriteLine("Score is: {0} to {1} with the end of round {2}.", playerOne.getScore(), playerTwo.getScore(), this.round);
                    playerTwo.addOneToScore();
                    this.round += 1;
                }
                else {
                    Console.WriteLine("Do you want to play again? press 'y' for yes or 'n' for no.");
                    playerOne.setChoice(Console.ReadLine());
                    if (playerOne.getChoice() != "y")
                    {
                        Console.WriteLine("Let's play again some other time!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
