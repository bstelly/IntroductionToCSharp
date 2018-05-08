using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using _1.Containers;

namespace _2.CombatForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            characters = new List<Character>();
            statDisplay.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputName.Text != null || inputName.Text != "")
            {
                Random rand = new Random();
                Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
                SavingThrows.Add("Strength", new Stat("strength", rand.Next(1, 11),
                    "Determines which weapons a character can use"));
                SavingThrows.Add("Dexterity", new Stat("Dexterity", rand.Next(1, 11),
                    "A measure of a character's attack, movement speed, and accuracy."));
                SavingThrows.Add("Constitution", new Stat("Constitution", rand.Next(1, 11),
                    "A measure of how sturdy a character is"));
                SavingThrows.Add("Intelligence", new Stat("Intelligence", rand.Next(1, 11),
                    "A measure of a character's problem-solving ability."));
                SavingThrows.Add("Wisdom", new Stat("Wisdom", rand.Next(1, 11),
                    "A measure of a character's common sense and/or spirituality."));
                SavingThrows.Add("Charisma", new Stat("Charisma", rand.Next(1, 11),
                    "A measure of a characters social skills"));
                Character newChar = new Character()
                {
                    CharacterName = inputName.Text,
                    ExperiencePoints = 1,
                    Level = 1,
                    SavingThrows = SavingThrows
                };
                characters.Add(newChar);
                createdChars.Items.Add(newChar.CharacterName);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            statDisplay.Text = "";
            for (int i = 0; i < characters.Count; i++)
            {
                if (createdChars.Text == characters[i].CharacterName)
                {
                    foreach (var variable in characters[i].SavingThrows)
                    {
                        statDisplay.Text += "Name = ";
                        statDisplay.Text += variable.Value.Name;
                        statDisplay.AppendText(Environment.NewLine);
                        statDisplay.Text += "Value = ";
                        statDisplay.Text += variable.Value.Value;
                        statDisplay.AppendText(Environment.NewLine);
                        statDisplay.Text += "Description = ";
                        statDisplay.Text += variable.Value.Description;
                        statDisplay.AppendText(Environment.NewLine);
                        statDisplay.AppendText(Environment.NewLine);
                    }

                    break;
                }
            }
        }

    }
}
