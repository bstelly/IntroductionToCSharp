using System.Collections.Generic;

namespace _2.CombatForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createChar = new System.Windows.Forms.Button();
            this.statDisplay = new System.Windows.Forms.TextBox();
            this.createdChars = new System.Windows.Forms.ComboBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createChar
            // 
            this.createChar.Location = new System.Drawing.Point(71, 80);
            this.createChar.Name = "createChar";
            this.createChar.Size = new System.Drawing.Size(105, 23);
            this.createChar.TabIndex = 0;
            this.createChar.Text = "Create Character";
            this.createChar.UseVisualStyleBackColor = true;
            this.createChar.Click += new System.EventHandler(this.button1_Click);
            // 
            // statDisplay
            // 
            this.statDisplay.Location = new System.Drawing.Point(232, 12);
            this.statDisplay.Multiline = true;
            this.statDisplay.Name = "statDisplay";
            this.statDisplay.Size = new System.Drawing.Size(318, 369);
            this.statDisplay.TabIndex = 1;
            this.statDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // createdChars
            // 
            this.createdChars.FormattingEnabled = true;
            this.createdChars.Location = new System.Drawing.Point(31, 158);
            this.createdChars.Name = "createdChars";
            this.createdChars.Size = new System.Drawing.Size(164, 21);
            this.createdChars.TabIndex = 2;
            this.createdChars.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(12, 54);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(164, 20);
            this.inputName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 393);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.createdChars);
            this.Controls.Add(this.statDisplay);
            this.Controls.Add(this.createChar);
            this.Name = "Form1";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createChar;
        private System.Windows.Forms.TextBox statDisplay;
        private Character character;
        private List<Character> characters;
        private System.Windows.Forms.ComboBox createdChars;
        private System.Windows.Forms.TextBox inputName;
    }
}

