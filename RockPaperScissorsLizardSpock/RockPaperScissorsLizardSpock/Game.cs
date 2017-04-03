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
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! \nHere are the rules: "
                + "\nPaper covers Rock, \nRock crushes Lizard, \nLizard poisons Spock, \nSpock smashes Scissors, \nScissors decapitates Lizard, \nLizard eats Paper, \nPaper disproves Spock, \nSpock vaporizes Rock, \nand as it always has Rock crushes Scissors.\n");
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
                    Console.WriteLine("You are playing against the machine. His name is HAL.\n");
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
                Console.WriteLine("Tie, you both chose the same thing, do over.\n");
                TakeTurns();
            }
            else if(player1.choice != player2.choice)
            {
                //comparison formula.
                int judge;
                judge = (5 + player1.choice - player2.choice) % 5;
                if (judge == 1 || judge == 3)
                {
                    player1.score += 1;
                    Console.WriteLine(player1.name + " chose " + player1.displayChoice + " which beats " + player2.displayChoice + " as chosen by " + player2.name + "."
                    + "\n" + player1.name + " wins this round."
                    + "\n" + player1.name + " your new score is " + player1.score + "."
                    + "\n" + player2.name + " your score is " + player2.score + ".\n");
                }
                else if (judge == 2 || judge == 4)
                {
                    player2.score += 1;
                    Console.WriteLine(player2.name + " chose " + player2.displayChoice + " which beats " + player1.displayChoice + " as chosen by " + player1.name + "."
                    + "\n" + player2.name + " your new score is " + player2.score + "."
                    + "\n" + player1.name + " your score is " + player1.score + ".\n");

                }
            }
        }

        public void CheckWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine(player1.name + " is the Winner of the best of 3 match!");
                PlayAgain();
            }
            else if (player2.score == 2)
            {
                Console.WriteLine(player2.name + " is the Winner of the best of 3 match!");
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
                    Console.WriteLine("Here we go again for another best in three.\n");
                    player1.score = 0;
                    player2.score = 0;
                    TakeTurns();
                    break;
                case "2":
                    Console.WriteLine("Thank you for playing!\n");
                    break;
                default:
                    Console.WriteLine("Not a valid option.\n");
                    PlayAgain();
                    break;
            }
        }
    }
}
