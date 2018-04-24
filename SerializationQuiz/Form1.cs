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


namespace SerializationQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display.ReadOnly = true;
            player = new Player(0, 0);
            XpForNextLvl = 1000;
            DisplayText();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("Character Save.json");
            writer.Write(JsonConvert.SerializeObject(player, Formatting.Indented));
            writer.Close();
        }

        private void GainXpButton_Click(object sender, EventArgs e)
        {
            player.Experience += 50;
            DisplayText();
            CheckForLevelUp();
        }

        private void DisplayText()
        {
            Display.Text = "Player" + Environment.NewLine;
            Display.Text += "Experience: " + player.Experience + Environment.NewLine;
            Display.Text += "Level: " + player.Level + Environment.NewLine + Environment.NewLine;
            Display.Text += "XP until Level up:  " + (XpForNextLvl - player.Experience);
        }

        private void CheckForLevelUp()
        {
            if (player.Experience == XpForNextLvl)
            {
                player.Experience = 0;
                player.Level += 1;
                DisplayText();
            }
        }

    }
}
