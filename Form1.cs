using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                    DgvSQL.showMessage(messageText, "数据库连接成功", DgvSQL.ErrorCode.Ok);
                }
                catch (Exception ex)
                {
                    DgvSQL.showMessage(messageText, "Error " + ex.Message, DgvSQL.ErrorCode.Error);
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
        private DialogResult EditScript(showScript sscript)
        {
            var resp = sscript.ShowDialog();
            if (resp == DialogResult.OK)
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
            return resp;
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
                        DgvSQL.fresh_table_grid(select_node, tables_show, Dbcon, messageText);
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
            showScript script = new showScript();
            if (DgvSQL.rowsTruct.Count != 0)
            {
                foreach (var dic in DgvSQL.rowsTruct)
                {
                    string columnsName = "";
                    foreach (var dic2 in dic.Value)
                    {
                        columnsName += string.Format("`{0}` = '{1}', ", dic2.Key, dic2.Value);
                    }
                    columnsName = columnsName.Substring(0, columnsName.Length - 2);
                    //DgvSQL.showMessage(messageText, string.Format("index:{0}, update:{1} = {2}", dic.Key, columnsName, rowsVolue), DgvSQL.ErrorCode.Msg);
                    script.sqlScript.AppendText(string.Format("UPDATE `{0}`.`{1}` SET {2} WHERE (`id` = '{3}');\r\n", DgvSQL.database_and_table_names[0],
                        DgvSQL.database_and_table_names[1], columnsName, tables_show.Rows[dic.Key].Cells[0].Value));
                }
            }
            if (DgvSQL.newInsert.Count != 0)
            {
                foreach (int i in DgvSQL.newInsert)
                {
                    if (tables_show.Rows[i].Cells[0].Value != null)
                    {
                        string columnsName = "";
                        string rowsVolue = "";
                        for (int j = 0; j < tables_show.ColumnCount; j++)
                        {
                            if(tables_show.Rows[i].Cells[j].Value != null)
                            {
                                columnsName += string.Format("`{0}`, ", tables_show.Columns[j].HeaderText);
                                rowsVolue += string.Format("'{0}', ", tables_show.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        columnsName = columnsName.Substring(0, columnsName.Length - 2);
                        rowsVolue = rowsVolue.Substring(0, rowsVolue.Length - 2);
                        script.sqlScript.AppendText(string.Format("INSERT INTO `{0}`.`{1}` ({2}) VALUES ({3})", DgvSQL.database_and_table_names[0],
                            DgvSQL.database_and_table_names[1], columnsName, rowsVolue));
                    }
                }
            }
            script.sqlScript.SelectionStart = script.sqlScript.TextLength;
            var resp = EditScript(script);
            if (resp == DialogResult.OK)
                DgvSQL.rowsTruct.Clear();
        }

        private void tables_show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //思路整理
            //修改记录参数：
            //大于原来的行数为插入新一行数据，并更新现在的行数
            //行数不变的值更新表示为参数更新，记录所修改的行索引（RowsIndex）以及列索引（columnsIndex）
            //更新的数据统一到应用按钮所在行数进行统计，并生成SQL语句。
            if (tables_show.Rows.Count == DgvSQL.rowsCount)
            {
                //数据更新
                //这一行是否有被修改过
                if (DgvSQL.rowsTruct.ContainsKey(e.RowIndex))
                {
                    //这一个属性值是否有被修改过
                    if (DgvSQL.rowsTruct[e.RowIndex].ContainsKey(tables_show.Columns[e.ColumnIndex].HeaderText))
                    {
                        DgvSQL.rowsTruct[e.RowIndex][tables_show.Columns[e.ColumnIndex].HeaderText] = tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    //否则添加这一行的修改记录
                    else
                    {
                        DgvSQL.rowsTruct[e.RowIndex].Add(tables_show.Columns[e.ColumnIndex].HeaderText,
                            tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                }
                //否则添加新一行的修改记录
                else
                {
                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>() {
                            {tables_show.Columns[e.ColumnIndex].HeaderText,
                                tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}
                        };
                    DgvSQL.rowsTruct.Add(e.RowIndex, keyValuePairs);
                }
            }
            else if (tables_show.Rows.Count > DgvSQL.rowsCount)
            {
                DgvSQL.showMessage(messageText, string.Format("增加的{0}", e.RowIndex), DgvSQL.ErrorCode.Msg);
            }
        }
        //*************表格右键操作*******************
        private void tables_show_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(e.RowIndex > 0)
                {
                    tables_show.ContextMenuStrip = table_Rclick;
                }
            }
        }

        private void freash_grid_Click(object sender, EventArgs e)
        {
            DgvSQL.UpdataGrid(tables_show, string.Format("SELECT * FROM {0}.{1}", DgvSQL.database_and_table_names[0], 
                DgvSQL.database_and_table_names[1]), Dbcon, messageText);
            //表格状态更新
            tables_show.ReadOnly = false;
            tables_show.AllowUserToAddRows = true;
        }

        private void delete_Rows_Click(object sender, EventArgs e)
        {

        }
        //********************************************
        
        
    }
}
