using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using Newtonsoft.Json;


namespace SerializationWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var directory = Environment.CurrentDirectory;
            var dialogue = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText(directory + @"\Dialogue.json"));
            display.ReadOnly = true;
                DataGridViewRow row = (DataGridViewRow) grid.RowTemplate.Clone();
                string[] strings = {dialogue.DialogueRoot[i].DialogueNode[0].ConverstationID};
                row.CreateCells(grid, strings);
                grid.Rows.Add(strings);

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
