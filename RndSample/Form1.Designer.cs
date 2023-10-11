namespace RndSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRevDesc = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblSuit = new System.Windows.Forms.Label();
            this.lblNbr = new System.Windows.Forms.Label();
            this.ckIsReversed = new System.Windows.Forms.CheckBox();
            this.lblDivinatory = new System.Windows.Forms.Label();
            this.lblWriters = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.drawOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuCommands});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuCommands
            // 
            this.tsMenuCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawOneToolStripMenuItem});
            this.tsMenuCommands.Name = "tsMenuCommands";
            this.tsMenuCommands.Size = new System.Drawing.Size(81, 20);
            this.tsMenuCommands.Text = "&Commands";
           
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblWriters);
            this.splitContainer1.Panel1.Controls.Add(this.lblDivinatory);
            this.splitContainer1.Panel1.Controls.Add(this.ckIsReversed);
            this.splitContainer1.Panel1.Controls.Add(this.lblNbr);
            this.splitContainer1.Panel1.Controls.Add(this.lblSuit);
            this.splitContainer1.Panel1.Controls.Add(this.lblNotes);
            this.splitContainer1.Panel1.Controls.Add(this.lblRevDesc);
            this.splitContainer1.Panel1.Controls.Add(this.lblDesc);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(951, 747);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(146, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "lblName";
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(28, 199);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(276, 79);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "lblDescription";
            // 
            // lblRevDesc
            // 
            this.lblRevDesc.Location = new System.Drawing.Point(25, 297);
            this.lblRevDesc.Name = "lblRevDesc";
            this.lblRevDesc.Size = new System.Drawing.Size(276, 103);
            this.lblRevDesc.TabIndex = 3;
            this.lblRevDesc.Text = "lblReversedDescription";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(25, 410);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(45, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "lblNotes";
            // 
            // lblSuit
            // 
            this.lblSuit.AutoSize = true;
            this.lblSuit.Location = new System.Drawing.Point(146, 81);
            this.lblSuit.Name = "lblSuit";
            this.lblSuit.Size = new System.Drawing.Size(25, 13);
            this.lblSuit.TabIndex = 5;
            this.lblSuit.Text = "Suit";
            // 
            // lblNbr
            // 
            this.lblNbr.AutoSize = true;
            this.lblNbr.Location = new System.Drawing.Point(147, 120);
            this.lblNbr.Name = "lblNbr";
            this.lblNbr.Size = new System.Drawing.Size(44, 13);
            this.lblNbr.TabIndex = 6;
            this.lblNbr.Text = "Number";
            // 
            // ckIsReversed
            // 
            this.ckIsReversed.AutoSize = true;
            this.ckIsReversed.Location = new System.Drawing.Point(149, 160);
            this.ckIsReversed.Name = "ckIsReversed";
            this.ckIsReversed.Size = new System.Drawing.Size(92, 17);
            this.ckIsReversed.TabIndex = 7;
            this.ckIsReversed.Text = "ckIsReversed";
            this.ckIsReversed.UseVisualStyleBackColor = true;
            // 
            // lblDivinatory
            // 
            this.lblDivinatory.AutoSize = true;
            this.lblDivinatory.Location = new System.Drawing.Point(24, 518);
            this.lblDivinatory.Name = "lblDivinatory";
            this.lblDivinatory.Size = new System.Drawing.Size(54, 13);
            this.lblDivinatory.TabIndex = 8;
            this.lblDivinatory.Text = "Divinatory";
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.Location = new System.Drawing.Point(25, 597);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(50, 13);
            this.lblWriters.TabIndex = 9;
            this.lblWriters.Text = "lblWriters";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(57, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 133);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(230, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 133);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(405, 44);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 133);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // drawOneToolStripMenuItem
            // 
            this.drawOneToolStripMenuItem.Name = "drawOneToolStripMenuItem";
            this.drawOneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawOneToolStripMenuItem.Text = "&Draw One";
            this.drawOneToolStripMenuItem.Click += new System.EventHandler(this.drawOneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(951, 771);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RndSample";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuCommands;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRevDesc;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblSuit;
        private System.Windows.Forms.Label lblDivinatory;
        private System.Windows.Forms.CheckBox ckIsReversed;
        private System.Windows.Forms.Label lblNbr;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem drawOneToolStripMenuItem;
    }
}

