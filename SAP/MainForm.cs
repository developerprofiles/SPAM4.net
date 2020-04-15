using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccountLayer;

namespace SAP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartOfAccounts ca = new ChartOfAccounts();
            ca.ShowDialog();
        }

        private void editAccountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountType at = new AccountType();
            at.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //AddSap add = new AddSap();
            //add.ShowDialog();

            JournalAdd add = new JournalAdd();
            add.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalDelete jd = new JournalDelete();
            jd.ShowDialog();
        }

        private void listGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(1);
            frm.ShowDialog();
        }

        private void listChartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(2);
            frm.ShowDialog();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.SetReport(3);
            frm.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLedger sl = new ShowLedger();
            sl.ShowDialog();

        }

        private void showJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowJournal sh = new ShowJournal();
            sh.ShowDialog();
        }

        private void pLAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowP_L pl = new ShowP_L();
            pl.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBalanceSheet bs = new ShowBalanceSheet();
            bs.Show();
        }
    }
}
