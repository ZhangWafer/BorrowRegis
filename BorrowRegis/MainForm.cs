using System;
using System.Windows.Forms;
using BorrowRegis.审批窗口;
using BorrowRegis.登记页面;

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
            Hide();
            Borrow borrowForm=new Borrow();
            borrowForm.Show();
        }

        private void LostBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Lost lostForm = new Lost();
            lostForm.Show();
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ApproveChoose approveChooseForm = new ApproveChoose();
            approveChooseForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.permission )
            {
                ApproveBtn.Enabled = true;
            }
            else
            {
                ApproveBtn.Enabled = false;
            }
        }
    }
}
