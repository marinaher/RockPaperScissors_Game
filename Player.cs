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
       public int round;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }
        public string getName()
        {
            return this.name;
        }
        public void setChoice(string choice)
        {
            this.choice = choice;
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
        public int setScore()
        {
            return this.score;
        }
        public int getRound()
        {
            return this.round;
        }
        public int setRound()
        {
            return this.round;
        }
    }
}
