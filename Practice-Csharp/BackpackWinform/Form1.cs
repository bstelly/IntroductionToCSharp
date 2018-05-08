using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace BackpackWinform
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            m_Pictures = new List<System.Windows.Forms.PictureBox>
            {
                picturePotion,
                pictureAntidote,
                pictureShield,
                pictureVest,
                pictureGun,
                pictureKnife
            };
            var playerInventory = new Backpack();
            player = new Player(playerInventory);
            packables = new List<IPackable> {
               new HPotion(),
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

            InvScreen = new Form2(player, this);

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
                InvScreen = new Form2(player, this);
            }
            InvScreen.Show();
            Hide();
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picturePotion.Visible = false;
                packables[0].PickedUp = true;
                player.Inventory.Packables.Add(packables[0]);
            }
        }

        private void contextMenuStrip2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureAntidote.Visible = false;
                packables[1].PickedUp = true;
                player.Inventory.Packables.Add(packables[1]);
            }
        }

        private void contextMenuStrip3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureShield.Visible = false;
                packables[2].PickedUp = true;
                player.Inventory.Packables.Add(packables[2]);
            }
        }

        private void contextMenuStrip4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureVest.Visible = false;
                packables[3].PickedUp = true;
                player.Inventory.Packables.Add(packables[3]);
            }
        }

        private void contextMenuStrip5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureGun.Visible = false;
                packables[4].PickedUp = true;
                player.Inventory.Packables.Add(packables[4]);
            }
        }

        private void contextMenuStrip6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureKnife.Visible = false;
                packables[5].PickedUp = true;
                player.Inventory.Packables.Add(packables[5]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var directory = Environment.CurrentDirectory;
            var json = JsonConvert.SerializeObject(player.Inventory, Formatting.Indented);
            System.IO.File.WriteAllText(directory + @"\save.json", json);
        }
    }
}
