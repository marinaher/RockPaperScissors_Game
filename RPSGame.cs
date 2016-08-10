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
        int round = 1;
        int numberOfRounds = 3;

        public void RunGame()
        {
            Console.WriteLine("Welcome to my Rock Paper Scissors Game!");
            Console.WriteLine("Rules are simple! \n You get to choose rock, paper or scissors.");
            Console.WriteLine("What is your name?");
            this.playerOne = new Player(Console.ReadLine());
            Console.WriteLine("Your opponents' name is? \n If you want to play against computer, type in 'NONE'.");
            this.playerTwo = new Player(Console.ReadLine());
        }
        public string randomAnswer()
        {
            Random number = new Random();
            int answer = number.Next(0, 2);
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
                Console.WriteLine("Now, let's get started! \n Do you choose rock, paper or scissors?");
            }
        }

    }
}
