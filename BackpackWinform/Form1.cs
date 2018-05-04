using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BackpackWinform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var playerInventory = new Backpack();
            player = new Player(playerInventory);
            packables = new List<IPackable> { new HPotion(),
               new Antidote(),
               new Shield(),
               new BodyArmor(),
               new Gun(),
               new Knife() };
            picturePotion.ImageLocation = packables[0].ImageDirectory;
            pictureAntidote.ImageLocation = packables[1].ImageDirectory;
            pictureShield.ImageLocation = packables[2].ImageDirectory;
            pictureVest.ImageLocation = packables[3].ImageDirectory;
            pictureGun.ImageLocation = packables[4].ImageDirectory;
            pictureKnife.ImageLocation = packables[5].ImageDirectory;

            InvScreen = new Form2(player);

            var pictures = new List<System.Windows.Forms.PictureBox> {
            picturePotion,
            pictureAntidote,
            pictureShield,
            pictureVest,
            pictureGun,
            pictureKnife };

            picturePotion.ContextMenuStrip = contextMenuStrip1;
            pictureAntidote.ContextMenuStrip = contextMenuStrip2;
            pictureShield.ContextMenuStrip = contextMenuStrip3;
            pictureVest.ContextMenuStrip = contextMenuStrip4;
            pictureGun.ContextMenuStrip = contextMenuStrip5;
            pictureKnife.ContextMenuStrip = contextMenuStrip6;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InvScreen != null)
            {
                InvScreen.Hide();
                InvScreen = new Form2(player);
            }
            InvScreen.Show();
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            picturePotion.Visible = false;
            packables[0].PickedUp = true;
            player.Inventory.Packables.Add(packables[0]);
        }

        private void contextMenuStrip2_MouseClick(object sender, MouseEventArgs e)
        {
            pictureAntidote.Visible = false;
            packables[1].PickedUp = true;
            player.Inventory.Packables.Add(packables[1]);
        }

        private void contextMenuStrip3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureShield.Visible = false;
            packables[2].PickedUp = true;
            player.Inventory.Packables.Add(packables[2]);
        }

        private void contextMenuStrip4_MouseClick(object sender, MouseEventArgs e)
        {
            pictureVest.Visible = false;
            packables[3].PickedUp = true;
            player.Inventory.Packables.Add(packables[3]);

        }

        private void contextMenuStrip5_MouseClick(object sender, MouseEventArgs e)
        {
            pictureGun.Visible = false;
            packables[4].PickedUp = true;
            player.Inventory.Packables.Add(packables[4]);
        }

        private void contextMenuStrip6_MouseClick(object sender, MouseEventArgs e)
        {
            pictureKnife.Visible = false;
            packables[5].PickedUp = true;
            player.Inventory.Packables.Add(packables[5]);
        }
    }
}
