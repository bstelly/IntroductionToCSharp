using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                Description = "Determines which weapons a character can use"
            };

            Stat dexterity = new Stat()
            {
                Name = "Dexterity",
                Value = 4,
                Description = " "
            };

            Stat constitution = new Stat()
            {
                Name = "Constitution",
                Value = 5,
                Description = " "
            };

            Stat intelligence = new Stat()
            {
                Name = "Intelligence",
                Value = 6,
                Description = " "
            };

            Stat wisdom = new Stat()
            {
                Name = "Wisdom",
                Value = 5,
                Description = " "
            };

            Stat charisma = new Stat()
            {
                Name = "Charisma",
                Value = 4,
                Description = " "
            };
            character.SavingThrows.Add("Strength", strength);
            character.SavingThrows.Add("Dexterity", dexterity);
            character.SavingThrows.Add("Constitution", constitution);
            character.SavingThrows.Add("Intelligence", intelligence);
            character.SavingThrows.Add("Wisdom", wisdom);
            character.SavingThrows.Add("Charisma", charisma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            foreach (var VARIABLE in character.SavingThrows)
            {

            }

            ;
        }
    }
}
