using System;
using System.Windows.Forms;

namespace BorrowRegis.审批窗口
{
    public partial class ApproveChoose : Form
    {
        public ApproveChoose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            BorrowApproveForm borrowApproveForm = new BorrowApproveForm();
            borrowApproveForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            LostApproveForm lostApproveForm = new LostApproveForm();
            lostApproveForm.Show();
        }
    }
}
