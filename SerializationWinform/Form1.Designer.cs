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
            this.SpecialityAnimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConversationID,
            this.ParticipantName,
            this.EmoteType,
            this.Side,
            this.Line,
            this.SpecialityAnimation,
            this.SpecialtyCamera,
            this.Participants,
            this.ConversationSummary});
            this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1275, 352);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_RowHeaderMouseClick);
            // 
            // ConversationID
            // 
            this.ConversationID.HeaderText = "ConversationID";
            this.ConversationID.Name = "ConversationID";
            this.ConversationID.ReadOnly = true;
            this.ConversationID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ParticipantName";
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.ReadOnly = true;
            this.ParticipantName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EmoteType
            // 
            this.EmoteType.HeaderText = "EmoteType";
            this.EmoteType.Name = "EmoteType";
            this.EmoteType.ReadOnly = true;
            this.EmoteType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Side
            // 
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            this.Side.ReadOnly = true;
            this.Side.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Side.Width = 45;
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Line.Width = 282;
            // 
            // SpecialityAnimation
            // 
            this.SpecialityAnimation.HeaderText = "SpecialiyAnimation";
            this.SpecialityAnimation.Name = "SpecialityAnimation";
            this.SpecialityAnimation.ReadOnly = true;
            this.SpecialityAnimation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SpecialtyCamera
            // 
            this.SpecialtyCamera.HeaderText = "SpecialtyCamera";
            this.SpecialtyCamera.Name = "SpecialtyCamera";
            this.SpecialtyCamera.ReadOnly = true;
            this.SpecialtyCamera.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Participants
            // 
            this.Participants.HeaderText = "Participants";
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            this.Participants.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Participants.Width = 67;
            // 
            // ConversationSummary
            // 
            this.ConversationSummary.HeaderText = "ConversationSummary";
            this.ConversationSummary.Name = "ConversationSummary";
            this.ConversationSummary.ReadOnly = true;
            this.ConversationSummary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConversationSummary.Width = 321;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(101, 379);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(1058, 96);
            this.display.TabIndex = 1;
            // 
            // NextDialogue
            // 
            this.NextDialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDialogue.Location = new System.Drawing.Point(568, 494);
            this.NextDialogue.Name = "NextDialogue";
            this.NextDialogue.Size = new System.Drawing.Size(146, 87);
            this.NextDialogue.TabIndex = 2;
            this.NextDialogue.Text = "Next Dialogue";
            this.NextDialogue.UseVisualStyleBackColor = true;
            this.NextDialogue.Click += new System.EventHandler(this.NextDialogue_Click);
            // 
            // PrevConvButton
            // 
            this.PrevConvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevConvButton.Location = new System.Drawing.Point(481, 587);
            this.PrevConvButton.Name = "PrevConvButton";
            this.PrevConvButton.Size = new System.Drawing.Size(146, 87);
            this.PrevConvButton.TabIndex = 3;
            this.PrevConvButton.Text = "Previous Conversation";
            this.PrevConvButton.UseVisualStyleBackColor = true;
            this.PrevConvButton.Click += new System.EventHandler(this.PrevConvButton_Click);
            // 
            // NextConvButton
            // 
            this.NextConvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextConvButton.Location = new System.Drawing.Point(655, 587);
            this.NextConvButton.Name = "NextConvButton";
            this.NextConvButton.Size = new System.Drawing.Size(146, 87);
            this.NextConvButton.TabIndex = 4;
            this.NextConvButton.Text = "Next Conversation";
            this.NextConvButton.UseVisualStyleBackColor = true;
            this.NextConvButton.Click += new System.EventHandler(this.NextConvButton_Click);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialityAnimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConversationSummary;
        private DialogueTree dialogue;
        private int dialogueLines;
    }
}
