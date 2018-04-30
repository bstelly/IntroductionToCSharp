namespace RockPaperScissors
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
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RockButton.Location = new System.Drawing.Point(12, 12);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(65, 65);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperButton.Location = new System.Drawing.Point(12, 101);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(65, 65);
            this.PaperButton.TabIndex = 1;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(106, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(318, 241);
            this.Display.TabIndex = 2;
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScissorsButton.Location = new System.Drawing.Point(12, 188);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(65, 65);
            this.ScissorsButton.TabIndex = 3;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(343, 259);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(81, 29);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 300);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button SaveButton;
        public RPS game;
    }
}

