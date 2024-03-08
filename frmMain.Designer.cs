namespace Sample
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commqandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildMRUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mRUArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtIntent = new System.Windows.Forms.TextBox();
            this.txtInterpretation = new System.Windows.Forms.TextBox();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.lblFormSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMRU = new System.Windows.Forms.TextBox();
            this.searchSuitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commqandsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commqandsToolStripMenuItem
            // 
            this.commqandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawOneToolStripMenuItem,
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem,
            this.buildMRUToolStripMenuItem});
            this.commqandsToolStripMenuItem.Name = "commqandsToolStripMenuItem";
            this.commqandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commqandsToolStripMenuItem.Text = "&Commands";
            // 
            // drawOneToolStripMenuItem
            // 
            this.drawOneToolStripMenuItem.Name = "drawOneToolStripMenuItem";
            this.drawOneToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.drawOneToolStripMenuItem.Text = "&Draw One";
            this.drawOneToolStripMenuItem.Click += new System.EventHandler(this.drawOneToolStripMenuItem_Click);
            // 
            // createTarotJournalDataAndCopyToClipboardToolStripMenuItem
            // 
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem.Name = "createTarotJournalDataAndCopyToClipboardToolStripMenuItem";
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem.Text = "&Create Tarot Journal Data and Copy to Clipboard";
            this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.createTarotJournalDataAndCopyToClipboardToolStripMenuItem_Click);
            // 
            // buildMRUToolStripMenuItem
            // 
            this.buildMRUToolStripMenuItem.Name = "buildMRUToolStripMenuItem";
            this.buildMRUToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.buildMRUToolStripMenuItem.Text = "&Build MRU";
            this.buildMRUToolStripMenuItem.Click += new System.EventHandler(this.buildMRUToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRUArticleToolStripMenuItem,
            this.searchSuitsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mRUArticleToolStripMenuItem
            // 
            this.mRUArticleToolStripMenuItem.Name = "mRUArticleToolStripMenuItem";
            this.mRUArticleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mRUArticleToolStripMenuItem.Text = "&MRU Article";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(24, 233);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "lblName";
            // 
            // lblQuote
            // 
            this.lblQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(112, 108);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(325, 112);
            this.lblQuote.TabIndex = 4;
            this.lblQuote.Text = "Quote";
            // 
            // lblSummary
            // 
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(24, 259);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(292, 386);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "label2";
            // 
            // btnDraw
            // 
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(465, 84);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(59, 23);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtIntent
            // 
            this.txtIntent.BackColor = System.Drawing.Color.Black;
            this.txtIntent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntent.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIntent.Location = new System.Drawing.Point(27, 27);
            this.txtIntent.Multiline = true;
            this.txtIntent.Name = "txtIntent";
            this.txtIntent.Size = new System.Drawing.Size(497, 51);
            this.txtIntent.TabIndex = 1;
            this.txtIntent.Text = "Enter Your Intent for this card drawing.";
            // 
            // txtInterpretation
            // 
            this.txtInterpretation.BackColor = System.Drawing.Color.Black;
            this.txtInterpretation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterpretation.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtInterpretation.Location = new System.Drawing.Point(24, 666);
            this.txtInterpretation.Multiline = true;
            this.txtInterpretation.Name = "txtInterpretation";
            this.txtInterpretation.Size = new System.Drawing.Size(500, 51);
            this.txtInterpretation.TabIndex = 3;
            this.txtInterpretation.Text = "Enter your thoughts about why this card was drawn.";
            // 
            // txtDecision
            // 
            this.txtDecision.BackColor = System.Drawing.Color.Black;
            this.txtDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecision.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDecision.Location = new System.Drawing.Point(24, 732);
            this.txtDecision.Multiline = true;
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(500, 49);
            this.txtDecision.TabIndex = 6;
            this.txtDecision.Text = "What is Your Decision Based on above?";
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(362, 259);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(91, 46);
            this.btnReveal.TabIndex = 7;
            this.btnReveal.Text = "Expand";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // lblFormSize
            // 
            this.lblFormSize.AutoSize = true;
            this.lblFormSize.Location = new System.Drawing.Point(359, 308);
            this.lblFormSize.Name = "lblFormSize";
            this.lblFormSize.Size = new System.Drawing.Size(105, 13);
            this.lblFormSize.TabIndex = 8;
            this.lblFormSize.Text = "FrmSize: is 1043,332";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(556, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 766);
            this.panel1.TabIndex = 9;
            // 
            // txtMRU
            // 
            this.txtMRU.BackColor = System.Drawing.Color.Black;
            this.txtMRU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRU.ForeColor = System.Drawing.Color.LemonChiffon;
            this.txtMRU.Location = new System.Drawing.Point(323, 339);
            this.txtMRU.Multiline = true;
            this.txtMRU.Name = "txtMRU";
            this.txtMRU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMRU.Size = new System.Drawing.Size(201, 306);
            this.txtMRU.TabIndex = 10;
            // 
            // searchSuitsToolStripMenuItem
            // 
            this.searchSuitsToolStripMenuItem.Name = "searchSuitsToolStripMenuItem";
            this.searchSuitsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchSuitsToolStripMenuItem.Text = "Search Suits";
            this.searchSuitsToolStripMenuItem.Click += new System.EventHandler(this.searchSuitsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(27, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(549, 793);
            this.Controls.Add(this.txtMRU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFormSize);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.txtInterpretation);
            this.Controls.Add(this.txtIntent);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commqandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawOneToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtIntent;
        private System.Windows.Forms.TextBox txtInterpretation;
        private System.Windows.Forms.ToolStripMenuItem createTarotJournalDataAndCopyToClipboardToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDecision;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Label lblFormSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRUArticleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMRU;
        private System.Windows.Forms.ToolStripMenuItem buildMRUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSuitsToolStripMenuItem;
    }
}