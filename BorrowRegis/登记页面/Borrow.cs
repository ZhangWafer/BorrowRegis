using System;
using System.Windows.Forms;

namespace BorrowRegis.登记页面
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private bool IsTextboxEmpty()
        {
            bool emptyBool = false;
            foreach (var textbox in Controls)
            {
                if (textbox is TextBox)
                {
                    if (string.IsNullOrEmpty((textbox as TextBox).Text))
                    {
                        emptyBool = true;
                        MessageBox.Show(@"填写内容不得为空");
                        break;
                    }
                }
            }
            return emptyBool;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //为空返回
            if (IsTextboxEmpty())
            {
                return;
            }
            string sqlstring = "INSERT INTO BorrowRecord (applicantId,respondentId,approvalId,approvalDepartment,barcode,borrowTime,returnTime,keepPlace)VALUES ('" + borrowPeople.Text+"','"+borrowedPeople.Text+"','"+approveNum.Text+"','"+
                             approveClass.Text+"','"+Barcode.Text+"','" + borrowTime.Value.ToString("yyyyMMdd")+"','"+returnTime.Value.ToString("yyyyMMdd")+"','"+keepPlace.Text+"')";
            //执行sql语句
            SqlHelper.ExecuteNonQuery(sqlstring);
            MessageBox.Show(@"申请提交成功！");
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm=new MainForm();
            mainForm.Show();
        }
    }
}
