using System;
using System.Windows.Forms;

namespace BorrowRegis.审批窗口
{
    public partial class BorrowApproveForm : Form
    {
        public BorrowApproveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm=new MainForm();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string personId = Properties.Settings.Default.loginAccount;
            string sqlstring =
                "select [id] as \'序号\',[applicantId] as \'本方办理人\',[respondentId] as \'对方办理人\',[approvalId] as \'审批人工号\'," +
                "[approvalDepartment] as \'审批人课别\',[barcode],[borrowTime] as \'转接时间\',[returnTime] as \'预计返还时间\'," +
                "[keepPlace] as \'借出后保管场所\' ,(CASE approveBool WHEN 1 THEN \'审批\' WHEN 0 THEN \'未审批\'  END )as \'审批状态\' FROM [BorrowDB].[dbo].[BorrowRecord] where approvalId = '"+ personId + "' and approveBool='False'";
            dataGridView1.DataSource = SqlHelper.ExecuteDataTable(sqlstring);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Width = 180;
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[9].Width = 200;
        }

        private string _dataIndex;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //取出选中序号
            int selectedIndex = e.RowIndex;
            //取出选中的值
            if (selectedIndex>=0)
            {
                _dataIndex = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_dataIndex==null)
            {
                MessageBox.Show(@"请选择一条申请进行审批");
                return;
            }
            var result = MessageBox.Show(@"是否确定审批", @"提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result==DialogResult.OK)
            {
                string approveString = "UPDATE [BorrowDB].[dbo].[BorrowRecord] SET [approveBool] = \'True\' WHERE id = \'" + _dataIndex + "\'";
                SqlHelper.ExecuteNonQuery(approveString);
                MessageBox.Show(@"审批成功！");
            }
            
        }
    }
}
