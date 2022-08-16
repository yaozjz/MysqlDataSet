using System;
using System.Drawing;
using System.Windows.Forms;

namespace MySQLDataSet
{
    public partial class showScript : Form
    {
        public showScript()
        {
            InitializeComponent();
            textLineHeight = sqlScript.Lines.Length;
        }
        public int textLineHeight = 0;

        private void okBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //行号显示
        private void sqlScript_TextChanged(object sender, EventArgs e)
        {
            KeyWordHightLight.SetHightLight(sqlScript, Color.Blue, textLineHeight);
            if (textLineHeight != sqlScript.Lines.Length)
            {
                KeyWordHightLight.ShowLineOfText(sqlScript, panelLine);
                //更新行高
                textLineHeight = sqlScript.Lines.Length;
            }
        }
        //行号显示
        private void sqlScript_VScroll(object sender, EventArgs e)
        {
            KeyWordHightLight.ShowLineOfText(sqlScript, panelLine);
        }

        private void panelLine_Paint(object sender, PaintEventArgs e)
        {
            KeyWordHightLight.ShowLineOfText(sqlScript, panelLine);
        }
        //窗口运行时
        private void showScript_Activated(object sender, EventArgs e)
        {
            sqlScript.Focus();
            KeyWordHightLight.SetHightLight(sqlScript, Color.Blue, 0);
        }
    }
}
