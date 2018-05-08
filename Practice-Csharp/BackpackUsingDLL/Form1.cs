using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackpackWinform;

namespace BackpackUsingDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var packables = new List<IPackable>
            {
                new Antidote(),
                new BodyArmor(),
                new Gun(),
                new HPotion(),
                new Knife(),
                new Shield()
            };
            MainForm mainForm = new MainForm();
            backpack = new Backpack();
            backpack.Packables.AddRange(packables);
            player = new Player(backpack);
            Form2 InvScreen = new Form2(player, mainForm);
            mainForm.Show();
        }
    }
}
