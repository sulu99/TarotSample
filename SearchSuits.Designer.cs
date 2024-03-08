namespace Sample
{
    partial class SearchSuits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSuits));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemChooseGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.majorArcanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentaclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMajorArcana = new System.Windows.Forms.Panel();
            this.txtDivineMeaning = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.lblDescriptionReversed = new System.Windows.Forms.Label();
            this.lblGeneralDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelMajorArcana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemChooseGroup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemChooseGroup
            // 
            this.menuItemChooseGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.majorArcanaToolStripMenuItem,
            this.cupsToolStripMenuItem,
            this.swordsToolStripMenuItem,
            this.pentaclesToolStripMenuItem,
            this.wandsToolStripMenuItem});
            this.menuItemChooseGroup.Name = "menuItemChooseGroup";
            this.menuItemChooseGroup.Size = new System.Drawing.Size(86, 20);
            this.menuItemChooseGroup.Text = "Select Group";
            // 
            // majorArcanaToolStripMenuItem
            // 
            this.majorArcanaToolStripMenuItem.Name = "majorArcanaToolStripMenuItem";
            this.majorArcanaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.majorArcanaToolStripMenuItem.Text = "&Major Arcana";
            this.majorArcanaToolStripMenuItem.Click += new System.EventHandler(this.majorArcanaToolStripMenuItem_Click);
            // 
            // cupsToolStripMenuItem
            // 
            this.cupsToolStripMenuItem.Name = "cupsToolStripMenuItem";
            this.cupsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cupsToolStripMenuItem.Text = "&Cups";
            this.cupsToolStripMenuItem.Click += new System.EventHandler(this.cupsToolStripMenuItem_Click);
            // 
            // swordsToolStripMenuItem
            // 
            this.swordsToolStripMenuItem.Name = "swordsToolStripMenuItem";
            this.swordsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.swordsToolStripMenuItem.Text = "&Swords";
            this.swordsToolStripMenuItem.Click += new System.EventHandler(this.swordsToolStripMenuItem_Click);
            // 
            // pentaclesToolStripMenuItem
            // 
            this.pentaclesToolStripMenuItem.Name = "pentaclesToolStripMenuItem";
            this.pentaclesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pentaclesToolStripMenuItem.Text = "&Pentacles";
            this.pentaclesToolStripMenuItem.Click += new System.EventHandler(this.pentaclesToolStripMenuItem_Click);
            // 
            // wandsToolStripMenuItem
            // 
            this.wandsToolStripMenuItem.Name = "wandsToolStripMenuItem";
            this.wandsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.wandsToolStripMenuItem.Text = "&Wands";
            this.wandsToolStripMenuItem.Click += new System.EventHandler(this.wandsToolStripMenuItem_Click);
            // 
            // panelMajorArcana
            // 
            this.panelMajorArcana.Controls.Add(this.txtDivineMeaning);
            this.panelMajorArcana.Controls.Add(this.label2);
            this.panelMajorArcana.Controls.Add(this.combo1);
            this.panelMajorArcana.Controls.Add(this.lblDescriptionReversed);
            this.panelMajorArcana.Controls.Add(this.lblGeneralDescription);
            this.panelMajorArcana.Controls.Add(this.lblTitle);
            this.panelMajorArcana.Controls.Add(this.picBox1);
            this.panelMajorArcana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMajorArcana.Location = new System.Drawing.Point(0, 24);
            this.panelMajorArcana.Name = "panelMajorArcana";
            this.panelMajorArcana.Size = new System.Drawing.Size(800, 426);
            this.panelMajorArcana.TabIndex = 1;
            // 
            // txtDivineMeaning
            // 
            this.txtDivineMeaning.BackColor = System.Drawing.Color.Black;
            this.txtDivineMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivineMeaning.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.txtDivineMeaning.Location = new System.Drawing.Point(202, 198);
            this.txtDivineMeaning.Multiline = true;
            this.txtDivineMeaning.Name = "txtDivineMeaning";
            this.txtDivineMeaning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDivineMeaning.Size = new System.Drawing.Size(577, 216);
            this.txtDivineMeaning.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List of Cards in Group";
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(22, 197);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(159, 21);
            this.combo1.TabIndex = 4;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.combo1_SelectedIndexChanged);
            // 
            // lblDescriptionReversed
            // 
            this.lblDescriptionReversed.AutoSize = true;
            this.lblDescriptionReversed.Location = new System.Drawing.Point(157, 111);
            this.lblDescriptionReversed.Name = "lblDescriptionReversed";
            this.lblDescriptionReversed.Size = new System.Drawing.Size(116, 13);
            this.lblDescriptionReversed.TabIndex = 3;
            this.lblDescriptionReversed.Text = "lblDescriptionReversed";
            // 
            // lblGeneralDescription
            // 
            this.lblGeneralDescription.AutoSize = true;
            this.lblGeneralDescription.Location = new System.Drawing.Point(157, 51);
            this.lblGeneralDescription.Name = "lblGeneralDescription";
            this.lblGeneralDescription.Size = new System.Drawing.Size(107, 13);
            this.lblGeneralDescription.TabIndex = 2;
            this.lblGeneralDescription.Text = "lblGeneralDescription";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(157, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "lblTitle";
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(22, 16);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(103, 147);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "*Select Group First**";
            // 
            // SearchSuits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMajorArcana);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SearchSuits";
            this.Text = "SearchSuits";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMajorArcana.ResumeLayout(false);
            this.panelMajorArcana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemChooseGroup;
        private System.Windows.Forms.ToolStripMenuItem majorArcanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentaclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wandsToolStripMenuItem;
        private System.Windows.Forms.Panel panelMajorArcana;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescriptionReversed;
        private System.Windows.Forms.Label lblGeneralDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.TextBox txtDivineMeaning;
        private System.Windows.Forms.Label label1;
    }
}