using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLDataSet
{
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
            tableName.Text = "new_table";
        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tableData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int nowIndex = tableData.CurrentRow.Index;
            if(nowIndex == 0)
            {
                tableData.Rows[nowIndex].Cells[0].Value = "idnew_table";
                ((DataGridViewComboBoxCell)tableData.Rows[nowIndex].Cells[1]).Value = "INT";
                tableData.Rows[nowIndex].Cells[2].Value = true;
                tableData.Rows[nowIndex].Cells[3].Value = true;
            }
            else if(nowIndex > 0)
            {
                tableData.Rows[nowIndex].Cells[0].Value = string.Format("new_tablecol{0}",nowIndex);
                ((DataGridViewComboBoxCell)tableData.Rows[nowIndex].Cells[1]).Value = "VARCHAR(45)";
            }
        }
        //删除列
        private void delRows_Click(object sender, EventArgs e)
        {
            tableData.Rows.Remove(tableData.SelectedRows[0]);
        }

        private void tableData_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    (sender as DataGridView).CurrentRow.Selected = false;
                    (sender as DataGridView).Rows[e.RowIndex].Selected = true;
                    tableData.ContextMenuStrip = tableRightBt;
                }
            }
        }
    }
}
