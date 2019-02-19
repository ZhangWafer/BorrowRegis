using System;
using System.Windows.Forms;

namespace BorrowRegis.登记页面
{
    public partial class Lost : Form
    {
        public Lost()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //为空返回
            if (IsTextboxEmpty())
            {
                return;
            }
            //sql语句
            string sqlstring = "INSERT INTO LostRecord (applicantId,respondentId,approvalId,approvalDepartment,barcode,lostTime)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
                               textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +"')";
            //执行sql语句
            SqlHelper.ExecuteNonQuery(sqlstring);
            MessageBox.Show(@"遗失申请提交成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
