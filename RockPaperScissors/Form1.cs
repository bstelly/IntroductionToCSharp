using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Display.ReadOnly = true;
            game = new RPS();
            Display.Text = "Player Wins: " + game.tally[0] + "\tCPU Wins: " + game.tally[1];
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            NewRound("Rock");
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            NewRound("Paper");
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            NewRound("Scissors");
        }

        public void NewRound(string choice)
        {
            game.SelectPlayerChoice(choice);
            game.SelectComputerChoice();
            var results = game.CheckForVictory();
            Display.Text = "Player Wins: " + game.tally[0] + "        CPU Wins: " + game.tally[1];
            Display.Text += Environment.NewLine;
            Display.Text += Environment.NewLine;
            Display.Text += "Player: " + game.PlayerChoice + Environment.NewLine;
            Display.Text += "          vs." + Environment.NewLine;
            Display.Text += "CPU: " + game.ComputerChoice + Environment.NewLine;
            Display.Text += Environment.NewLine;
            Display.Text += results;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Save.json");
            writer.Write(JsonConvert.SerializeObject(game, Formatting.Indented));
            writer.Close();
        }
    }
}
