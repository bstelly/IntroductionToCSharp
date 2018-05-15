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
using System.Threading;
using Newtonsoft.Json;


namespace SerializationWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            var directory = Environment.CurrentDirectory;
            dialogue = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText(directory + @"\Dialogue.json"));
            display.ReadOnly = true;

            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    DataGridViewRow row = (DataGridViewRow) grid.RowTemplate.Clone();
                    string[] strings =
                    {
                        dialogue.DialogueRoot[i].DialogueNode[j].ConversationID,
                        dialogue.DialogueRoot[i].DialogueNode[j].ParticipantName,
                        dialogue.DialogueRoot[i].DialogueNode[j].EmoteType,
                        dialogue.DialogueRoot[i].DialogueNode[j].Side,
                        dialogue.DialogueRoot[i].DialogueNode[j].Line,
                        dialogue.DialogueRoot[i].DialogueNode[j].SpecialityAnimation,
                        dialogue.DialogueRoot[i].DialogueNode[j].SpecialtyCamera,
                        dialogue.DialogueRoot[i].DialogueNode[j].Participants,
                        dialogue.DialogueRoot[i].DialogueNode[j].ConversationSummary,
                    };
                    row.CreateCells(grid, strings);
                    grid.Rows.Add(strings);
                }
            }

            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    dialogueLines += 1;
                }
            }

        }

        private void NextDialogue_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(dialogue.DialogueRoot[dialogue.DialogueRoot.Count - 1]
                .DialogueNode[dialogue.DialogueRoot[dialogue.DialogueRoot.Count - 1].DialogueNode.Count - 1].Line))
            {
                for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
                {
                    for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                    {
                        if (display.Text ==
                            dialogue.DialogueRoot[i].DialogueNode[j].ConversationID + ", " +
                            dialogue.DialogueRoot[i].DialogueNode[j].ParticipantName + ", " +
                            dialogue.DialogueRoot[i].DialogueNode[j].EmoteType + ":" +
                            Environment.NewLine +
                            "\"" + dialogue.DialogueRoot[i].DialogueNode[j].Line + "\""
                            )
                        {
                            if (dialogue.DialogueRoot[i].DialogueNode.Count == j + 1)
                            {
                                display.Text = dialogue.DialogueRoot[i + 1].DialogueNode[0].ConversationID + ", ";
                                display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].ParticipantName + ", ";
                                display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].EmoteType + ":";
                                display.Text += Environment.NewLine;
                                display.Text += "\"" + dialogue.DialogueRoot[i + 1].DialogueNode[0].Line + "\"";
                                return;
                            }

                            display.Text = dialogue.DialogueRoot[i].DialogueNode[j + 1].ConversationID + ", ";
                            display.Text += dialogue.DialogueRoot[i].DialogueNode[j + 1].ParticipantName + ", ";
                            display.Text += dialogue.DialogueRoot[i].DialogueNode[j + 1].EmoteType + ":";
                            display.Text += Environment.NewLine;
                            display.Text += "\"" + dialogue.DialogueRoot[i].DialogueNode[j + 1].Line + "\"";
                            return;
                        }
                    }
                }
            }
        }


        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string convID = grid.SelectedRows[0].Cells[0].Value + string.Empty;
            string partName = grid.SelectedRows[0].Cells[1].Value + string.Empty;
            string emote = grid.SelectedRows[0].Cells[2].Value + string.Empty;
            string line = grid.SelectedRows[0].Cells[4].Value + string.Empty;
            display.Text = convID + ", " + partName + ", " + emote + ":" +
                           Environment.NewLine + "\"" + line + "\"";
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.SelectedCells.Count == 1 && e.RowIndex != -1)
            {
                display.Text = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + string.Empty;
            }
        }

        private void PrevConvButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    if (display.Text.Contains(dialogue.DialogueRoot[i].DialogueNode[j].Line) && i > 0)
                    {
                        display.Text = dialogue.DialogueRoot[i - 1].DialogueNode[0].ConversationID + ", ";
                        display.Text += dialogue.DialogueRoot[i - 1].DialogueNode[0].ParticipantName + ", ";
                        display.Text += dialogue.DialogueRoot[i - 1].DialogueNode[0].EmoteType + ":";
                        display.Text += Environment.NewLine;
                        display.Text += "\"" + dialogue.DialogueRoot[i - 1].DialogueNode[0].Line + "\"";
                        return;
                    }
                }
            }
        }

        private void NextConvButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dialogue.DialogueRoot.Count; i++)
            {
                for (int j = 0; j < dialogue.DialogueRoot[i].DialogueNode.Count; j++)
                {
                    if (display.Text.Contains(dialogue.DialogueRoot[i].DialogueNode[j].Line) &&
                        i < dialogue.DialogueRoot.Count - 1)
                    {
                        display.Text = dialogue.DialogueRoot[i + 1].DialogueNode[0].ConversationID + ", ";
                        display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].ParticipantName + ", ";
                        display.Text += dialogue.DialogueRoot[i + 1].DialogueNode[0].EmoteType + ":";
                        display.Text += Environment.NewLine;
                        display.Text += "\"" + dialogue.DialogueRoot[i + 1].DialogueNode[0].Line + "\"";
                        return;
                    }
                }
            }
        }
    }
}