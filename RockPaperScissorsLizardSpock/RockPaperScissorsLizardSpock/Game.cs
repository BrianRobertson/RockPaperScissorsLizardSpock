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
            SetUpGame();
            TakeTurns();
        }

        public void SetUpGame()
        {
            Console.WriteLine("Welcome to the Game! Instructions go here.\n");
            string type = GetGameType();
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

        public string GetGameType()
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
                    return GetGameType();
            }
        }

        public void TakeTurns()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.GetChoice();
                player2.GetChoice();
                CompareChoices();
                CheckWinner();
            }
        }

        public void CompareChoices()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("Tie, do over.");
                TakeTurns();
            }
            else if(player1.choice != player2.choice)
            {
                //comparison formula.
                Console.WriteLine("Game is on.");

                int judge;
                judge = (5 + player1.choice - player2.choice) % 5;
                if (judge == 1 || judge == 3)
                {
                    player1.score += 1;
                    Console.WriteLine(player1.name + player1.choice + " Wins round according to this math " + judge
                    + "\n Your new score is " + player1.score);
                }
                else if (judge == 2 || judge == 4)
                {
                    player2.score += 1;
                    Console.WriteLine(player2.name + player2.choice + " Wins round according to this math " + judge
                    + "\n Your new score is " + player2.score);
                }
            }
        }

        public void CheckWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine(player1.name + " is the Winner of the match!");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine(player2.name + " is the Winner of the match!");
            }
            else
            {
                TakeTurns();
            }
        }












    }
}
