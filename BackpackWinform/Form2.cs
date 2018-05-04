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

            for (int i = 0; i < packables.Count; i++)
            {
                if (packables[i].PickedUp == true)
                {
                    InvSlots[i].ImageLocation = packables[i].ImageDirectory;
                }
            }
            foreach (IPackable x in packables)
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
            }
        }
    }
}