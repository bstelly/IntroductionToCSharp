using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BackpackWinform
{
    public partial class Form2 : Form
    {
        public Form2(Player player)
        {
            Player = player;
            InitializeComponent();
            InvSlots = new List<System.Windows.Forms.PictureBox> {
                packBox1,
                packBox2,
                packBox3,
                packBox4,
                packBox5,
                packBox6,
                packBox7,
                packBox8,
                packBox9,
                packBox10 };

            for (int i = 0; i < player.Inventory.Packables.Count; i++)
            {
                if (player.Inventory.Packables[i].PickedUp == true)
                {
                    InvSlots[i].ImageLocation = player.Inventory.Packables[i].ImageDirectory;
                }
            }
            foreach (IPackable x in player.Inventory.Packables)
            {
                if (x.ImageDirectory == packBox1.ImageLocation)
                {
                    toolTip1.SetToolTip(packBox1, x.Name);
                }
                if (x.ImageDirectory == packBox2.ImageLocation)
                {
                    toolTip2.SetToolTip(packBox2, x.Name);
                }
                if (x.ImageDirectory == packBox3.ImageLocation)
                {
                    toolTip3.SetToolTip(packBox3, x.Name);
                }
                if (x.ImageDirectory == packBox4.ImageLocation)
                {
                    toolTip4.SetToolTip(packBox4, x.Name);
                }
                if (x.ImageDirectory == packBox5.ImageLocation)
                {
                    toolTip5.SetToolTip(packBox5, x.Name);
                }
                if (x.ImageDirectory == packBox6.ImageLocation)
                {
                    toolTip6.SetToolTip(packBox6, x.Name);
                }
                packBox1.ContextMenuStrip = contextMenuStrip1;
                packBox2.ContextMenuStrip = contextMenuStrip2;
                packBox3.ContextMenuStrip = contextMenuStrip3;
                packBox4.ContextMenuStrip = contextMenuStrip4;
                packBox5.ContextMenuStrip = contextMenuStrip5;
                packBox6.ContextMenuStrip = contextMenuStrip6;
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            packBox1.ImageLocation = null;
            packBox1.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[0]);
            
        }

        private void contextMenuStrip2_MouseClick(object sender, MouseEventArgs e)
        {
            packBox2.ImageLocation = null;
            packBox2.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[1]);
        }

        private void contextMenuStrip3_MouseClick(object sender, MouseEventArgs e)
        {
            packBox3.ImageLocation = null;
            packBox3.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[2]);
        }

        private void contextMenuStrip4_MouseClick(object sender, MouseEventArgs e)
        {
            packBox4.ImageLocation = null;
            packBox4.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[3]);
        }

        private void contextMenuStrip5_MouseClick(object sender, MouseEventArgs e)
        {
            packBox5.ImageLocation = null;
            packBox5.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[4]);
        }

        private void contextMenuStrip6_MouseClick(object sender, MouseEventArgs e)
        {
            packBox6.ImageLocation = null;
            packBox6.ContextMenuStrip = null;
            Player.Drop(Player.Inventory.Packables[5]);
        }
    }
}