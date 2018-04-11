using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            character = new Character();
            Stat strength = new Stat()
            {
                Name = "Strength",
                Value = 3,
                Description = "Determines which weapons a character can use."
            };

            Stat dexterity = new Stat()
            {
                Name = "Dexterity",
                Value = 4,
                Description = "A measure of a character's attack, movement speed, and accuracy."
            };

            Stat constitution = new Stat()
            {
                Name = "Constitution",
                Value = 5,
                Description = "A measure of how sturdy a character is."
            };

            Stat intelligence = new Stat()
            {
                Name = "Intelligence",
                Value = 6,
                Description = "A measure of a character's problem-solving ability."
            };

            Stat wisdom = new Stat()
            {
                Name = "Wisdom",
                Value = 5,
                Description = "A measure of a character's common sense and/or spirituality."
            };

            Stat charisma = new Stat()
            {
                Name = "Charisma",
                Value = 4,
                Description = "A measure of a character's social skills."
            };
            character.SavingThrows.Add("Strength", strength);
            character.SavingThrows.Add("Dexterity", dexterity);
            character.SavingThrows.Add("Constitution", constitution);
            character.SavingThrows.Add("Intelligence", intelligence);
            character.SavingThrows.Add("Wisdom", wisdom);
            character.SavingThrows.Add("Charisma", charisma);

            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
            foreach (var variable in character.SavingThrows)
            {
                textBox1.Text += "Name = ";
                textBox1.Text += variable.Value.Name;
                textBox1.AppendText(Environment.NewLine);
                textBox1.Text += "Value = ";
                textBox1.Text += variable.Value.Value;
                textBox1.AppendText(Environment.NewLine);
                textBox1.Text += "Description = ";
                textBox1.Text += variable.Value.Description;
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText(Environment.NewLine);


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
