using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BackpackWinform
{
    public partial class Form2 : Form
    {
        private MainForm m_ParentForm;
        public Form2(Player player, MainForm parentForm)
        {
            m_ParentForm = parentForm;
            Player = player;
            InitializeComponent();
            InvSlots = new List<System.Windows.Forms.PictureBox>
            {
                packBox1,
                packBox2,
                packBox3,
                packBox4,
                packBox5,
                packBox6,
                packBox7,
                packBox8,
                packBox9,
                packBox10
            };

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
            if (packBox1.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox1.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox1.ImageLocation = null;
                        packBox1.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }

        private void contextMenuStrip2_MouseClick(object sender, MouseEventArgs e)
        {
            if (packBox2.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox2.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox2.ImageLocation = null;
                        packBox2.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }

        private void contextMenuStrip3_MouseClick(object sender, MouseEventArgs e)
        {
            if (packBox3.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox3.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox3.ImageLocation = null;
                        packBox3.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }

        private void contextMenuStrip4_MouseClick(object sender, MouseEventArgs e)
        {
            if (packBox4.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox4.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox4.ImageLocation = null;
                        packBox4.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }

        private void contextMenuStrip5_MouseClick(object sender, MouseEventArgs e)
        {
            if (packBox5.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox5.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox5.ImageLocation = null;
                        packBox5.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }

        private void contextMenuStrip6_MouseClick(object sender, MouseEventArgs e)
        {
            if (packBox6.ImageLocation != null)
            {
                for (int i = 0; i < Player.Inventory.Packables.Count; i++)
                {
                    if (packBox6.ImageLocation.Contains(Player.Inventory.Packables[i].ImageDirectory))
                    {
                        packBox6.ImageLocation = null;
                        packBox6.ContextMenuStrip = null;
                        Player.Inventory.Packables[i].PickedUp = false;
                        Player.Drop(Player.Inventory.Packables[i]);
                        break;
                    }
                }
            }
        }



        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            m_ParentForm.CheckRoomInventory();
            m_ParentForm.Show();
        }
    }
}