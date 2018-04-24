namespace SerializationQuiz
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.GainXpButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(21, 267);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(187, 46);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GainXpButton
            // 
            this.GainXpButton.Location = new System.Drawing.Point(21, 89);
            this.GainXpButton.Name = "GainXpButton";
            this.GainXpButton.Size = new System.Drawing.Size(187, 79);
            this.GainXpButton.TabIndex = 1;
            this.GainXpButton.Text = "Gain Experience";
            this.GainXpButton.UseVisualStyleBackColor = true;
            this.GainXpButton.Click += new System.EventHandler(this.GainXpButton_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(262, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(231, 301);
            this.Display.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 337);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.GainXpButton);
            this.Controls.Add(this.SaveButton);
            this.Name = "Form1";
            this.Text = "Serialization Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button GainXpButton;
        private System.Windows.Forms.TextBox Display;
        private Player player;
        private int XpForNextLvl;

    }
}

