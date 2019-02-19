using System;
using System.Data;
using System.Windows.Forms;

namespace BorrowRegis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox1.Text = @"734549";
        }

       
        private void Login_Load(object sender, EventArgs e)
        {
           
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable nameTable = SqlHelper.ExecuteDataTable("select * from AccountTable");
            string selectResult = "Account='" + textBox1.Text + "' and Pwd='" + textBox2.Text + "'";
            DataRow[] dataRows = nameTable.Select(selectResult);
            if (dataRows.Length!=0)
            {
                if (dataRows[0][3].ToString() == "True")
                {
                    //审批人员权限
                    Properties.Settings.Default.permission = true;
                }
                else
                {
                    //操作人员权限
                    Properties.Settings.Default.permission = false;
                }
                Properties.Settings.Default.loginAccount = textBox1.Text;

                MainForm mform = new MainForm();
                mform.Show();
                Hide();
            }
        }

    }
}
