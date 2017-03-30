using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Player player1 = new Player();
        Player player2 = new Player();

        public void RunGame()
        {
            Console.WriteLine("Welcome to the Game! Instructions go here.\n");
            string type = GetType();
            if (type == "1")
            {
                player1.SetName();
                player2.SetName();
            }
            else if (type == "2")
            {
                player1.SetName();
                player2.SetName();
            }
        }


        public string GetType()
        {
            Console.WriteLine("What type of game are we playing? \n1. One player against the machine. \n2. Two players against each other.");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.WriteLine("You are playing against the machine.\n");
                    return type;
                case "2":
                    Console.WriteLine("You are playing against another person.\n");
                    return type;
                default:
                    Console.WriteLine("Not a valid option.\n");
                    return GetType();
            }
        }

    }
}
