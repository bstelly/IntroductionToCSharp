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
        public Form2(List<IPackable> packables)
        {
            backpack = new Backpack(packables);
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

            for (int i = 0; i < backpack.Packables.Count; i++)
            {
                if (backpack.Packables[i].PickedUp == true)
                {
                    InvSlots[i].ImageLocation = backpack.Packables[i].ImageDirectory;
                }
            }
        }
    }
}
