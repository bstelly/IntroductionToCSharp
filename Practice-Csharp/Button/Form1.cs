using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myButton = new Button(new Vector2.Vector2(100, 100), 50);
            myButton.OnClick += PrintButtonClicked;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            CheckForClick();
        }
    }
}
