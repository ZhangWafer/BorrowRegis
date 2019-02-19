using System;
using System.Windows.Forms;

namespace BorrowRegis.审批窗口
{
    public partial class LostApproveForm : Form
    {
        public LostApproveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string personId = Properties.Settings.Default.loginAccount;
            string sqlstring =
                "SELECT  [id] ,[applicantId] as \'本方办理人\' ,[respondentId] as \'对方办理人\'," +
                "[approvalId] as \'审批人工号\',[approvalDepartment] as \'审批人课别\',[barcode]," +
                "[lostTime] as \'遗失时间\',(CASE approveBool WHEN 1 THEN \'审批\' WHEN 0 THEN \'未审批\'  END ) as" +
                "  \'审批状态\' FROM [BorrowDB].[dbo].[LostRecord] where approveBool = '0' and approvalId = '" + personId + "'  ";
            dataGridView1.DataSource= SqlHelper.ExecuteDataTable(sqlstring);
            //隐藏第一列
            dataGridView1.Columns[0].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_dataIndex == null)
            {
                MessageBox.Show(@"请选择一条申请进行审批");
                return;
            }
            var result = MessageBox.Show(@"是否确定审批", @"提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string approveString = "UPDATE [BorrowDB].[dbo].[LostRecord] SET [approveBool] = \'True\' WHERE id = \'" + _dataIndex + "\'";
                SqlHelper.ExecuteNonQuery(approveString);
                MessageBox.Show(@"审批成功！");
            }

        }

        private string _dataIndex;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //取出选中序号
            int selectedIndex = e.RowIndex;
            //取出选中的值
            if (selectedIndex >= 0)
            {
                _dataIndex = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            }
        }
    }
}
