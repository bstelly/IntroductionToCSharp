using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SerializationWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            display.ReadOnly = true;
            var dialogue = new DialogueTree();
            dialogue = dialogue.GenerateObject();
            int i = 0;
            while (i < 9)
            {
                DataGridViewRow row = (DataGridViewRow) grid.RowTemplate.Clone();
                string[] strings = {"Some Value", "Another value", "one more value"};
                row.CreateCells(grid, strings);
                grid.Rows.Add(strings);
                i++;
            }

            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(grid);
            //row.Cells[0].Value = "some value";
            //row.Cells[1].Value = "next value";
            //grid.Rows.Add(row);
            //row.Cells[0].Value = "some value 2";
            //row.Cells[1].Value = "next value 2";
            //grid.Rows.Add(row);


        }

    }
}
