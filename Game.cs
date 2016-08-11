using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        string one = "rock";
        string two = "paper";
        string three = "scissors";
        int score;
        int round = 1;
        int numberOfRounds;

        public Game()
        {
            Console.WriteLine("Welcome to my Rock Paper Scissors Game!");
            Console.WriteLine("What is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("Your opponents' name is? \nIf you want to play against computer, type in 'computer'.");
            this.playerTwo = new Player(Console.ReadLine());
            this.score = 0;
            this.round = 1;
            this.numberOfRounds = 6;
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
        public void StartGame()
        {
            while (round <= numberOfRounds)
            {
                Console.WriteLine("Score is {0} to {1}.", playerOne.setScore(), playerTwo.setScore());
                Console.WriteLine("\nPick your choice: rock, paper or scissors {0}?", playerOne.getName());
                playerOne.setChoice(Console.ReadLine());
                if (playerTwo.getName() == "computer")
                {
                    playerTwo.setChoice(randomAnswer());
                }
                else
                {
                    Console.WriteLine("\n{0}, do you choose rock, paper, or scissors?", playerTwo.getName());
                    playerTwo.setChoice(Console.ReadLine());
                }

                if (playerOne.getChoice() == one && playerTwo.getChoice() == two)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), one, playerTwo.getName(), two);
                    playerTwo.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == two && playerTwo.getChoice() == one)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), two, playerTwo.getName(), one);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == three && playerTwo.getChoice() == two)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), three, playerTwo.getName(), two);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == one && playerTwo.getChoice() == three)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), one, playerTwo.getName(), three);
                    playerOne.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == three && playerTwo.getChoice() == one)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), three, playerTwo.getName(), one);
                    playerTwo.addOneToScore();
                    this.round += 1;
                }
                else if (playerOne.getChoice() == playerTwo.getChoice())
                {
                    Console.WriteLine("\nIt's a TIE");
                    this.round += 1;
                }
                else if (playerOne.getChoice() == two && playerTwo.getChoice() == three)
                {
                    Console.WriteLine("\n{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), two, playerTwo.getName(), three);
                    playerTwo.addOneToScore();
                    this.round += 1;
                }
                Console.WriteLine("Final Score: \n {0} has {1} \n {2} has {3},", playerOne.getName(), playerOne.getScore(), playerTwo.getName(), playerTwo.getScore());
                //Console.WriteLine("Do you want to keep playing? press 'y' for yes or 'n' for no.");
                //playerOne.setChoice(Console.ReadLine());
                //if (playerOne.getChoice() != "y")
                //{
                //    Console.WriteLine("Let's play again some other time!");
                //    Console.ReadLine();
                //    break;
                }
                }
            }
        }