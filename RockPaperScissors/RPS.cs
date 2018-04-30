using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RPS
    {
        public string PlayerChoice { get; set; }
        public string ComputerChoice { get; set; }
        private List<string> VictoryConditions = new List<string>
        {
            "Rock > Scissors",
            "Paper > Rock",
            "Scissors > Paper"
        };

        public int[] tally = {0, 0};

        public void SelectPlayerChoice(string choice)
        {
            PlayerChoice = choice;
        }

        public void SelectComputerChoice()
        {
            var rand = new Random();
            int choice = rand.Next(0, 3);
            switch (choice)
            {
                case 0:
                    ComputerChoice = "Rock";
                    break;
                case 1:
                    ComputerChoice = "Paper";
                    break;
                case 2:
                    ComputerChoice = "Scissors";
                    break;
            }
        }

        public string CheckForVictory()
        {
            string play = "";
            play = play + PlayerChoice + " > " + ComputerChoice;
            if (PlayerChoice == ComputerChoice)
            {
                return "Draw!";
            }
            if (VictoryConditions.Contains(play))
            {
                tally[0] += 1;
                return "Player Wins!";
            }
            tally[1] += 1;
            return "CPU Wins!";
        }
    }
}
