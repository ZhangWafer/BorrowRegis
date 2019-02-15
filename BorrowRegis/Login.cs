using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace BorrowRegis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private DataTable nameTable=new DataTable();
        private void Login_Load(object sender, EventArgs e)
        {
             nameTable = SqlHelper.ExecuteDataTable("select * from AccountTable");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectResult = "Account='" + textBox1.Text + "' and Pwd='" + textBox2.Text + "'";
            DataRow[] dataRows = nameTable.Select(selectResult);
            if (dataRows.Length!=0)
            {
                MainForm Mform = new MainForm();
                Mform.Show();
                this.Hide();
            }
        }


    }
}
