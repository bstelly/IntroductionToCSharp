using System.Collections.Generic;

namespace BackpackWinform
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonBackpack = new System.Windows.Forms.Button();
            this.pictureShield = new System.Windows.Forms.PictureBox();
            this.pictureAntidote = new System.Windows.Forms.PictureBox();
            this.pictureGun = new System.Windows.Forms.PictureBox();
            this.picturePotion = new System.Windows.Forms.PictureBox();
            this.pictureKnife = new System.Windows.Forms.PictureBox();
            this.pictureVest = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pickUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pickUpToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAntidote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKnife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBackpack
            // 
            this.ButtonBackpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackpack.Location = new System.Drawing.Point(1008, 256);
            this.ButtonBackpack.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBackpack.Name = "ButtonBackpack";
            this.ButtonBackpack.Size = new System.Drawing.Size(215, 215);
            this.ButtonBackpack.TabIndex = 0;
            this.ButtonBackpack.Text = "Open Backpack";
            this.ButtonBackpack.UseVisualStyleBackColor = true;
            this.ButtonBackpack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureShield
            // 
            this.pictureShield.BackColor = System.Drawing.Color.Transparent;
            this.pictureShield.Location = new System.Drawing.Point(691, 199);
            this.pictureShield.Name = "pictureShield";
            this.pictureShield.Size = new System.Drawing.Size(112, 98);
            this.pictureShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShield.TabIndex = 2;
            this.pictureShield.TabStop = false;
            // 
            // pictureAntidote
            // 
            this.pictureAntidote.BackColor = System.Drawing.Color.Transparent;
            this.pictureAntidote.Location = new System.Drawing.Point(758, 390);
            this.pictureAntidote.Name = "pictureAntidote";
            this.pictureAntidote.Size = new System.Drawing.Size(48, 44);
            this.pictureAntidote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAntidote.TabIndex = 3;
            this.pictureAntidote.TabStop = false;
            // 
            // pictureGun
            // 
            this.pictureGun.BackColor = System.Drawing.Color.Transparent;
            this.pictureGun.Location = new System.Drawing.Point(34, 341);
            this.pictureGun.Name = "pictureGun";
            this.pictureGun.Size = new System.Drawing.Size(92, 50);
            this.pictureGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGun.TabIndex = 4;
            this.pictureGun.TabStop = false;
            // 
            // picturePotion
            // 
            this.picturePotion.BackColor = System.Drawing.Color.Transparent;
            this.picturePotion.Location = new System.Drawing.Point(288, 175);
            this.picturePotion.Name = "picturePotion";
            this.picturePotion.Size = new System.Drawing.Size(58, 62);
            this.picturePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePotion.TabIndex = 5;
            this.picturePotion.TabStop = false;
            // 
            // pictureKnife
            // 
            this.pictureKnife.BackColor = System.Drawing.Color.Transparent;
            this.pictureKnife.Location = new System.Drawing.Point(633, 352);
            this.pictureKnife.Name = "pictureKnife";
            this.pictureKnife.Size = new System.Drawing.Size(84, 71);
            this.pictureKnife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKnife.TabIndex = 6;
            this.pictureKnife.TabStop = false;
            // 
            // pictureVest
            // 
            this.pictureVest.BackColor = System.Drawing.Color.Transparent;
            this.pictureVest.Location = new System.Drawing.Point(859, 396);
            this.pictureVest.Name = "pictureVest";
            this.pictureVest.Size = new System.Drawing.Size(100, 96);
            this.pictureVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVest.TabIndex = 7;
            this.pictureVest.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 28);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // dropToolStripMenuItem
            // 
            this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            this.dropToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.dropToolStripMenuItem.Text = "Pick Up";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(128, 28);
            this.contextMenuStrip2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip2_MouseClick);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(128, 28);
            this.contextMenuStrip3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip3_MouseClick);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem2});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(128, 28);
            this.contextMenuStrip4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip4_MouseClick);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem3});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(128, 28);
            this.contextMenuStrip5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip5_MouseClick);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpToolStripMenuItem4});
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(176, 56);
            this.contextMenuStrip6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip6_MouseClick);
            // 
            // pickUpToolStripMenuItem
            // 
            this.pickUpToolStripMenuItem.Name = "pickUpToolStripMenuItem";
            this.pickUpToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.pickUpToolStripMenuItem.Text = "Pick Up";
            // 
            // pickUpToolStripMenuItem1
            // 
            this.pickUpToolStripMenuItem1.Name = "pickUpToolStripMenuItem1";
            this.pickUpToolStripMenuItem1.Size = new System.Drawing.Size(127, 24);
            this.pickUpToolStripMenuItem1.Text = "Pick Up";
            // 
            // pickUpToolStripMenuItem2
            // 
            this.pickUpToolStripMenuItem2.Name = "pickUpToolStripMenuItem2";
            this.pickUpToolStripMenuItem2.Size = new System.Drawing.Size(127, 24);
            this.pickUpToolStripMenuItem2.Text = "Pick Up";
            // 
            // pickUpToolStripMenuItem3
            // 
            this.pickUpToolStripMenuItem3.Name = "pickUpToolStripMenuItem3";
            this.pickUpToolStripMenuItem3.Size = new System.Drawing.Size(127, 24);
            this.pickUpToolStripMenuItem3.Text = "Pick Up";
            // 
            // pickUpToolStripMenuItem4
            // 
            this.pickUpToolStripMenuItem4.Name = "pickUpToolStripMenuItem4";
            this.pickUpToolStripMenuItem4.Size = new System.Drawing.Size(127, 24);
            this.pickUpToolStripMenuItem4.Text = "Pick Up";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 722);
            this.Controls.Add(this.pictureVest);
            this.Controls.Add(this.pictureKnife);
            this.Controls.Add(this.picturePotion);
            this.Controls.Add(this.pictureGun);
            this.Controls.Add(this.pictureAntidote);
            this.Controls.Add(this.pictureShield);
            this.Controls.Add(this.ButtonBackpack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1272, 769);
            this.MinimumSize = new System.Drawing.Size(1272, 769);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backpack Demonstration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAntidote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKnife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private List<IPackable> packables;
        private System.Windows.Forms.Button ButtonBackpack;
        private System.Windows.Forms.PictureBox pictureShield;
        private System.Windows.Forms.PictureBox pictureAntidote;
        private System.Windows.Forms.PictureBox pictureGun;
        private System.Windows.Forms.PictureBox picturePotion;
        private System.Windows.Forms.PictureBox pictureKnife;
        private System.Windows.Forms.PictureBox pictureVest;
        private Form2 InvScreen;
        private Player player;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ToolStripMenuItem pickUpToolStripMenuItem4;
    }
}

