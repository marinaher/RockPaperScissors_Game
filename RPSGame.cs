﻿using System;
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
        int numberOfRounds = 3;

        public RPSGame()
        {
            //Console.WriteLine("Welcome to my Rock Paper Scissors Game!");
            //Console.WriteLine("Rules are simple! \n You get to choose rock, paper or scissors.");
            Console.WriteLine("What is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("Your opponents' name is? \n If you want to play against computer, type in 'none'.");
            this.playerTwo = new Player(Console.ReadLine());
            //numberOfRounds = Convert.ToInt32(Console.ReadLine());
            this.round = 1;
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
            while(round <= numberOfRounds)
            {
                Console.WriteLine("Welcome to my Rock Paper Scissors Game!");
                Console.WriteLine("Rules are simple! You make a choice and your friend or the computer will make a choice.");
                Console.WriteLine("Pick your choice: rock, paper or scissors {0}?", playerOne.getName());
                playerOne.setChoice(Console.ReadLine());
                if (playerTwo.getName() == "none")
                {
                    playerTwo.setChoice(randomAnswer());
                }
                else
                {
                    Console.WriteLine("Now, do you choose ROCK, PAPER, or SCISSORS {0}?", playerTwo.getName());
                    playerTwo.setChoice(Console.ReadLine());
                }
                if (playerOne.getChoice() == one && playerTwo.getChoice() == two)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {0} won the round!", playerOne.getName(), one, playerTwo.getName(), two);
                    round++;
                    playerTwo.addOneToScore();
                } else if(playerOne.getChoice() == two && playerTwo.getChoice() == one)
                {
                    Console.WriteLine("{0} picked {1} and {2} picked {3}! {2} won the round!", playerOne.getName(), two, playerTwo.getName(), one);
                    playerOne.addOneToScore();
                    round++;
                }
            }
        }

    }
}
