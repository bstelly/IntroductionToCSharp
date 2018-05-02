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
        public Form2()
        {
            InitializeComponent();
            string myDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\pics\shield.png";
            pictureBox2.ImageLocation = myDirectory;
            pictureBox1.Visible = false;
        }
    }
}
