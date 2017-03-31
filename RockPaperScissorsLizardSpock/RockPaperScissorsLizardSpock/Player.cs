using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public int score;
        public int choice;

        public Player()
        {
           this.score = 0;
        }
        public void SetName()
        {
            Console.WriteLine("Enter your player name.");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", Welcome to the game!\n");
        }
        public void GetChoice()
        {
            Console.WriteLine(name + " What do you choose?"
                + "\n1. Rock"
                + "\n2. Paper"
                + "\n3. Scissors"
                + "\n4. Spock"
                + "\n5. Lizard");
 //         choice = int.Parse(Console.ReadLine())-1;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You chose rock.\n");
                    choice = 0;
                    break;
                case "2":
                    Console.WriteLine("You chose paper.\n");
                    choice = 1;
                    break;
                case "3":
                    Console.WriteLine("You chose scissors.\n");
                    choice = 2;
                    break;
                case "4":
                    Console.WriteLine("You chose Spock.\n");
                    choice = 3;
                    break;
                case "5":
                    Console.WriteLine("You chose lizard.\n");
                    choice = 4;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    GetChoice();
                    break;
            }

        }
    }
}
