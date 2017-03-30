using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        string name;
        int score;
        string choice;
        public void SetName()
        {
            Console.WriteLine("Enter your player name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Welcome to the game!\n");
        }
    }
}
