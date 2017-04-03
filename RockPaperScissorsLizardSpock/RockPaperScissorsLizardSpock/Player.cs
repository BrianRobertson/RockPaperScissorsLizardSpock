using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public int score;
        public int choice;
        public string displayChoice;

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
        public virtual string GetInput()
        {
            Console.WriteLine(name + " What do you choose?"
               + "\n1. Rock"
               + "\n2. Paper"
               + "\n3. Scissors"
               + "\n4. Spock"
               + "\n5. Lizard");
            string input = Console.ReadLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.WriteLine("Thank you for your choice.\n");
            return input;
        }
        public void GetChoice(string input)
        {
            switch (input)
            {
                case "1":
                    choice = 0;
                    displayChoice = "Rock";
                    break;
                case "2":
                    choice = 1;
                    displayChoice = "Paper";
                    break;
                case "3":
                    choice = 2;
                    displayChoice = "Scissors";
                    break;
                case "4":
                    choice = 3;
                    displayChoice = "Spock";
                    break;
                case "5":
                    choice = 4;
                    displayChoice = "Lizard";
                    break;
                default:
                    Console.WriteLine("Not a valid choice.\n");
                    GetInput();
                    break;
            }
        }
    }
}
