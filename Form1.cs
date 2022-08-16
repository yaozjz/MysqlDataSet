using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MySQLDataSet
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            statusText.AppendText("未连接数据库。\r\n");
        }

        public MySqlConnection Dbcon;
        public bool Is_links = false;

        //登录数据库
        private bool LinkSQL()
        {
            login links = new login();
            if (links.ShowDialog() == DialogResult.OK)
            {
                mysqlDB mysql = new mysqlDB();
                statusText.Text = "";
                statusText.AppendText("连接到数据库:\r\n");
                statusText.AppendText("地址: " + links.ip_text.Text + ":" + links.port_text.Text + "\r\n");
                statusText.AppendText("用户: " + links.userName_text.Text + "\r\n");
                Dbcon = mysql.connetion(links.ip_text.Text, links.port_text.Text, links.userName_text.Text, links.passwd_text.Text, links.database_text.Text);
                try
                {
                    Dbcon.Open();
                    statusText.AppendText("状态: 连接成功\r\n");
                    DgvSQL.showMessage(messageText, "数据库连接成功", DgvSQL.Ok);
                }
                catch (Exception ex)
                {
                    DgvSQL.showMessage(messageText, "Error " + ex.Message, DgvSQL.Error);
                    statusText.AppendText("状态: 连接失败\r\n");
                    Is_links = false;
                    return false;
                }
            }
            else
            {
                if (!Is_links)
                    return false;
            }
            links.Dispose();
            return true;
        }
        /// <summary>
        /// 脚本编辑器
        /// </summary>
        /// <param name="sscript"></param>
        private void EditScript(showScript sscript)
        {
            if (sscript.ShowDialog() == DialogResult.OK)
            {
                string[] ln = sscript.sqlScript.Text.Split(';');
                foreach (string command in ln)
                {
                    //检查是否为空格或者多个空格
                    if (!string.IsNullOrWhiteSpace(command))
                    {
                        string comd = Regex.Replace(command, @"[\r\n]", "");
                        //debug用文本状态检测
                        //DgvSQL.showMessage(messageText, comd, DgvSQL.Msg);
                        //执行命令
                        KeyWordHightLight.CommandAction(comd, tables_show, messageText, Dbcon);
                    }
                }
            }
            sscript.Dispose();
        }

        //添加数据库
        private void addDB_Click(object sender, EventArgs e)
        {
            if (LinkSQL())
            {
                Is_links = true;
                DgvSQL.DBshow(Dbcon, database_tree);
            }
        }
        //窗口关闭
        private void closeBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //数据库刷新
        private void fresh_db_Click(object sender, EventArgs e)
        {
            if (!Is_links)
            {
                if (LinkSQL())
                {
                    Is_links = true;
                    DgvSQL.DBshow(Dbcon, database_tree);
                }
            }
            else
                DgvSQL.DBshow(Dbcon, database_tree);
            database_tree.ExpandAll();
        }

        private void add_table_Click(object sender, EventArgs e)
        {
            //添加数据库表单
            showScript script = new showScript();
            script.sqlScript.Text = "CREATE TABLE `text`.`new_table` (\r\n" +
                "  `idnew_table` INT NOT NULL,\r\n" +
                "  `new_tablecol` VARCHAR(45) NULL,\r\n" +
                "  PRIMARY KEY (`idnew_table`));";
            script.sqlScript.SelectionStart = script.sqlScript.TextLength;
            EditScript(script);
        }

        private void deltable_Click(object sender, EventArgs e)
        {
            //删除表单
            TreeNode select_node = database_tree.SelectedNode;
            showScript script = new showScript();
            script.sqlScript.Text = string.Format("DROP TABLE `{0}`.{1};", select_node.Parent.Text, select_node.Text);
            EditScript(script);
        }

        //脚本编辑器
        private void SqlScriptEdit_Click(object sender, EventArgs e)
        {
            EditScript(new showScript());
        }
        //数据库结构点击事件
        private void database_tree_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode select_node = database_tree.GetNodeAt(e.X, e.Y);
            //判断选中的结点是否为空
            if (select_node != null)
            {
                //选中该节点
                database_tree.SelectedNode = select_node;
                //表单选择项过滤
                if (select_node.Level == 1)
                {
                    //选中的是数据库
                    database_tree.ContextMenuStrip = db_cms;
                }
                else if (select_node.Level == 2)
                {
                    //选中的是表单，更新右键菜单栏
                    database_tree.ContextMenuStrip = tableRightClick;
                    if (e.Button == MouseButtons.Left)
                    {
                        DgvSQL dgvsql = new DgvSQL();
                        dgvsql.fresh_table_grid(select_node, tables_show, Dbcon, messageText);
                        //表格状态更新
                        tables_show.ReadOnly = false;
                        tables_show.AllowUserToAddRows = true;
                    }
                }
            }
            
        }
        /// <summary>
        /// 表格更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apply_Click(object sender, EventArgs e)
        {
            DgvSQL.showMessage(messageText, string.Format("添加的行索引{0}", tables_show.NewRowIndex), DgvSQL.Msg);
        }

        private void tables_show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DgvSQL.showMessage(messageText, string.Format("更改的索引{0}", tables_show.Rows[e.RowIndex]), DgvSQL.Msg);
        }
    }
}
