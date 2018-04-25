namespace SerializationWinform
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.ConversationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmoteType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialiyAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConversationSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.display = new System.Windows.Forms.TextBox();
            this.NextDialogue = new System.Windows.Forms.Button();
            this.PrevConvButton = new System.Windows.Forms.Button();
            this.NextConvButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.ParticipantName,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialiyAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary});
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(1275, 329);
            this.grid.TabIndex = 0;
            // 
            // ConversationID
            // 
            this.ConversationID.HeaderText = "ConversationID";
            this.ConversationID.Name = "ConversationID";
            this.ConversationID.ReadOnly = true;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ParticipantName";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            // 
            // EmoteType
            // 
            this.EmoteType.HeaderText = "EmoteType";
            this.EmoteType.Name = "EmoteType";
            this.EmoteType.ReadOnly = true;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Width = 70;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Width = 200;
            // 
            // SpecialiyAnimation
            // 
            this.SpecialiyAnimation.HeaderText = "SpecialiyAnimation";
            this.SpecialiyAnimation.Name = "SpecialiyAnimation";
            this.SpecialiyAnimation.ReadOnly = true;
            // 
            // SpecialtyCamera
            // 
            this.SpecialtyCamera.HeaderText = "SpecialtyCamera";
            this.SpecialtyCamera.Name = "SpecialtyCamera";
            this.SpecialtyCamera.ReadOnly = true;
            // 
            // Participants
            // 
            this.Participants.HeaderText = "Participants";
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            this.Participants.Width = 67;
            // 
            // ConversationSummary
            // 
            this.ConversationSummary.HeaderText = "ConversationSummary";
            this.ConversationSummary.Name = "ConversationSummary";
            this.ConversationSummary.ReadOnly = true;
            this.ConversationSummary.Width = 395;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(104, 360);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(1058, 96);
            this.display.TabIndex = 1;
            // 
            // NextDialogue
            // 
            this.NextDialogue.Location = new System.Drawing.Point(541, 479);
            this.NextDialogue.Name = "NextDialogue";
            this.NextDialogue.Size = new System.Drawing.Size(146, 87);
            this.NextDialogue.TabIndex = 2;
            this.NextDialogue.Text = "Next Dialogue";
            this.NextDialogue.UseVisualStyleBackColor = true;
            // 
            // PrevConvButton
            // 
            this.PrevConvButton.Location = new System.Drawing.Point(455, 587);
            this.PrevConvButton.Name = "PrevConvButton";
            this.PrevConvButton.Size = new System.Drawing.Size(146, 87);
            this.PrevConvButton.TabIndex = 3;
            this.PrevConvButton.Text = "Previous Conversation";
            this.PrevConvButton.UseVisualStyleBackColor = true;
            // 
            // NextConvButton
            // 
            this.NextConvButton.Location = new System.Drawing.Point(633, 587);
            this.NextConvButton.Name = "NextConvButton";
            this.NextConvButton.Size = new System.Drawing.Size(146, 87);
            this.NextConvButton.TabIndex = 4;
            this.NextConvButton.Text = "Next Conversation";
            this.NextConvButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1299, 686);
            this.Controls.Add(this.NextConvButton);
            this.Controls.Add(this.PrevConvButton);
            this.Controls.Add(this.NextDialogue);
            this.Controls.Add(this.display);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Dialogue";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button NextDialogue;
        private System.Windows.Forms.Button PrevConvButton;
        private System.Windows.Forms.Button NextConvButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmoteType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialiyAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationSummary;
    }
}
