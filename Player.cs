using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class Player
    {
       public string name;
       public string choice;
       public int score;

        public Player(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public string getChoice()
        {
            return this.choice;
        }
        public int getScore()
        {
            return this.score;
        }
        public void addOneToScore()
        {
            this.score++;
        }
    }
}
