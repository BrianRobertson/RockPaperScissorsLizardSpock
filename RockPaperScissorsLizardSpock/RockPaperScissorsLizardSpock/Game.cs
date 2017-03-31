using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        private Player player1;
        private Player player2;
        public Game()
        {
            player1 = new Human();
        }
        public void RunGame()
        {
            SetUpGame();
            TakeTurns();
        }

        private void SetUpGame()
        {
            Console.WriteLine("Welcome to the Game! Instructions go here.\n");
            string type = GetGameType();
            if (type == "1")
            {
                player2 = new AI();
                player1.SetName();
            }
            else if (type == "2")
            {
                player2 = new Human();
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
                string player1Input = player1.GetInput();
                player1.GetChoice(player1Input);

                string player2Input = player2.GetInput();
                player2.GetChoice(player2Input);

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
                PlayAgain();
            }
            else if (player2.score == 2)
            {
                Console.WriteLine(player2.name + " is the Winner of the match!");
                PlayAgain();
            }
            else
            {
                TakeTurns();
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine(player1.name + " and " + player2.name + ", Thank you for playing! Would you like to play again?"
                + "\n1. Yes \n2. No");           
            string playAgainDecision = Console.ReadLine();
            switch (playAgainDecision)
            {
                case "1":
                    Console.WriteLine("Here we go again.\n");
                    player1.score = 0;
                    player2.score = 0;
                    TakeTurns();
                    break;
                case "2":
                    Console.WriteLine("Thank you for playing!\n");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Not a valid option.\n");
                    PlayAgain();
                    break;
            }
        }
    }
}
