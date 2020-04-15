namespace SAP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listChartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.journalToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountTypeToolStripMenuItem,
            this.chartOfAccountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // editAccountTypeToolStripMenuItem
            // 
            this.editAccountTypeToolStripMenuItem.Name = "editAccountTypeToolStripMenuItem";
            this.editAccountTypeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editAccountTypeToolStripMenuItem.Text = "&Edit Account Type";
            this.editAccountTypeToolStripMenuItem.Click += new System.EventHandler(this.editAccountTypeToolStripMenuItem_Click);
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            this.chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            this.chartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chartOfAccountsToolStripMenuItem.Text = "&Chart Of Accounts";
            this.chartOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.chartOfAccountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.journalToolStripMenuItem.Text = "&Journal";
            this.journalToolStripMenuItem.Click += new System.EventHandler(this.journalToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aToolStripMenuItem.Text = "A&dd";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledgerToolStripMenuItem,
            this.trialBalanceToolStripMenuItem,
            this.pLAccountsToolStripMenuItem,
            this.balanceSheetToolStripMenuItem,
            this.printScheduleToolStripMenuItem,
            this.listGroupToolStripMenuItem,
            this.listChartOfAccountsToolStripMenuItem,
            this.showJournalToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // ledgerToolStripMenuItem
            // 
            this.ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            this.ledgerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ledgerToolStripMenuItem.Text = "&Ledger";
            this.ledgerToolStripMenuItem.Click += new System.EventHandler(this.ledgerToolStripMenuItem_Click);
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            this.trialBalanceToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.trialBalanceToolStripMenuItem.Text = "&Trial Balance";
            this.trialBalanceToolStripMenuItem.Click += new System.EventHandler(this.trialBalanceToolStripMenuItem_Click);
            // 
            // pLAccountsToolStripMenuItem
            // 
            this.pLAccountsToolStripMenuItem.Name = "pLAccountsToolStripMenuItem";
            this.pLAccountsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pLAccountsToolStripMenuItem.Text = "&P & L Accounts";
            this.pLAccountsToolStripMenuItem.Click += new System.EventHandler(this.pLAccountsToolStripMenuItem_Click);
            // 
            // balanceSheetToolStripMenuItem
            // 
            this.balanceSheetToolStripMenuItem.Name = "balanceSheetToolStripMenuItem";
            this.balanceSheetToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.balanceSheetToolStripMenuItem.Text = "&Balance Sheet";
            this.balanceSheetToolStripMenuItem.Click += new System.EventHandler(this.balanceSheetToolStripMenuItem_Click);
            // 
            // printScheduleToolStripMenuItem
            // 
            this.printScheduleToolStripMenuItem.Name = "printScheduleToolStripMenuItem";
            this.printScheduleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printScheduleToolStripMenuItem.Text = "P&rint Schedule";
            // 
            // listGroupToolStripMenuItem
            // 
            this.listGroupToolStripMenuItem.Name = "listGroupToolStripMenuItem";
            this.listGroupToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listGroupToolStripMenuItem.Text = "List Group";
            this.listGroupToolStripMenuItem.Click += new System.EventHandler(this.listGroupToolStripMenuItem_Click);
            // 
            // listChartOfAccountsToolStripMenuItem
            // 
            this.listChartOfAccountsToolStripMenuItem.Name = "listChartOfAccountsToolStripMenuItem";
            this.listChartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listChartOfAccountsToolStripMenuItem.Text = "List Chart Of Accounts";
            this.listChartOfAccountsToolStripMenuItem.Click += new System.EventHandler(this.listChartOfAccountsToolStripMenuItem_Click);
            // 
            // showJournalToolStripMenuItem
            // 
            this.showJournalToolStripMenuItem.Name = "showJournalToolStripMenuItem";
            this.showJournalToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.showJournalToolStripMenuItem.Text = "Show Journal";
            this.showJournalToolStripMenuItem.Click += new System.EventHandler(this.showJournalToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 245);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Financial Accounting";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listChartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showJournalToolStripMenuItem;
    }
}