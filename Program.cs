using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSGame game = new RPSGame();
            game.startGame();
            Console.WriteLine("Good Game!");
            Console.ReadLine();
        }
    }
}
