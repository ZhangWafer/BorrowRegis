using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BorrowRegis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow borrowForm=new Borrow();
            borrowForm.Show();
        }

        private void LostBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lost lostForm = new Lost();
            lostForm.Show();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lost lostForm = new Lost();
            lostForm.Show();
        }
    }
}
