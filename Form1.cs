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
            string dbName;
            string sqlStr = "";
            AddTable addTable = new AddTable();
            if (database_tree.SelectedNode.Level == 1)
                dbName = database_tree.SelectedNode.Text;
            else dbName = database_tree.SelectedNode.Parent.Text;
            addTable.schema.Text = dbName;
            if (addTable.ShowDialog() == DialogResult.OK)
            {
                string sql = string.Format("CREATE TABLE `{0}`.`{1}` (\r\n", dbName, addTable.tableName.Text);
                string primaryKeysSql = "";
                string OnlyIndex = "";
                for (int i = 0; i < addTable.tableData.Rows.Count - 1; i++)
                {
                    string columnsName = addTable.tableData.Rows[i].Cells[0].Value.ToString();
                    string dataType = addTable.tableData.Rows[i].Cells[1].Value.ToString();
                    bool notNull = Convert.ToBoolean(addTable.tableData.Rows[i].Cells[3].EditedFormattedValue);
                    bool unsignedChar = Convert.ToBoolean(addTable.tableData.Rows[i].Cells[5].EditedFormattedValue);
                    sql += string.Format("  `{0}` {1} ", columnsName, dataType);
                    if (unsignedChar)
                        sql += "UNSIGNED ";
                    if (notNull)
                        sql += "NOT ";
                    sql += "NULL,\r\n";
                    //额外添加部分
                    bool PK = Convert.ToBoolean(addTable.tableData.Rows[i].Cells[2].EditedFormattedValue);
                    bool uniqueIndex = Convert.ToBoolean(addTable.tableData.Rows[i].Cells[4].EditedFormattedValue);
                    if (PK) primaryKeysSql += string.Format("`{0}`, ", columnsName);
                    if (uniqueIndex) OnlyIndex += string.Format("  UNIQUE INDEX `{0}_UNIQUE` (`{0}` ASC),\r\n", columnsName);
                }
                //融合sql表达式
                primaryKeysSql = primaryKeysSql.Substring(0, primaryKeysSql.Length - 2);//删掉后面的空格和逗号
                if(OnlyIndex != string.Empty)
                {
                    OnlyIndex = OnlyIndex.Substring(0, OnlyIndex.Length - 3);//删掉后面的换行符、制表符和逗号
                    sql += string.Format("  PRIMARY KEY ({0}),\r\n", primaryKeysSql) + OnlyIndex + ");";
                }
                else sql += string.Format("  PRIMARY KEY ({0})", primaryKeysSql) + ");";

                sqlStr = sql;
                
            }
            addTable.Dispose();
            //添加数据库表单
            showScript script = new showScript();
            script.sqlScript.Text = sqlStr;
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
            DgvSQL.DBshow(Dbcon, database_tree);
            database_tree.ExpandAll();
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
            //update
            if (DgvSQL.rowsTruct.Count != 0)
            {
                foreach (var dic in DgvSQL.rowsTruct)
                {
                    foreach (var dic1 in dic.Value)
                    {
                        string columnsName = "";
                        foreach (var dic2 in dic1.Value)
                        {
                            columnsName += string.Format("`{0}` = '{1}', ", dic2.Key, dic2.Value);
                        }
                        columnsName = columnsName.Substring(0, columnsName.Length - 2);
                        script.sqlScript.AppendText(string.Format("UPDATE `{0}`.`{1}` SET {2} WHERE (`{3}` = '{4}');\r\n", DgvSQL.database_and_table_names[0],
                            DgvSQL.database_and_table_names[1], columnsName,
                            DgvSQL.primaryKeys[0], dic1.Key));
                    }
                }
            }
            //insert
            if (DgvSQL.newInsert.Count != 0)
            {
                foreach (int i in DgvSQL.newInsert)
                {
                    int keys = tables_show.Columns[DgvSQL.primaryKeys[0]].Index;
                    //检测主键是否为空
                    if (tables_show.Rows[i].Cells[keys].Value != null)
                    {
                        string columnsName = "";
                        string rowsVolue = "";
                        for (int j = 0; j < tables_show.ColumnCount; j++)
                        {
                            if (tables_show.Rows[i].Cells[j].Value != null)
                            {
                                columnsName += string.Format("`{0}`, ", tables_show.Columns[j].HeaderText);
                                rowsVolue += string.Format("'{0}', ", tables_show.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                        columnsName = columnsName.Substring(0, columnsName.Length - 2);
                        rowsVolue = rowsVolue.Substring(0, rowsVolue.Length - 2);
                        script.sqlScript.AppendText(string.Format("INSERT INTO `{0}`.`{1}` ({2}) VALUES ({3});\r\n", DgvSQL.database_and_table_names[0],
                            DgvSQL.database_and_table_names[1], columnsName, rowsVolue));
                    }
                    else
                    {
                        DgvSQL.showMessage(messageText, "请检查表单结构", DgvSQL.ErrorCode.Error);
                    }
                }
            }
            //delete
            foreach (var delsql in DgvSQL.delRows)
            {
                script.sqlScript.AppendText(delsql);
            }
            script.sqlScript.SelectionStart = script.sqlScript.TextLength;
            var resp = EditScript(script);
            if (resp == DialogResult.OK)
            {
                //清空数据
                DgvSQL.rowsTruct.Clear();
                DgvSQL.newInsert.Clear();
                DgvSQL.delRows.Clear();
            }
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
                    //修改过的情况
                    //字典结构
                    //索引值->id值->表头->表值
                    //这一个属性值是否有被修改过
                    foreach (var dic_ in DgvSQL.rowsTruct[e.RowIndex])
                    {
                        if (DgvSQL.rowsTruct[e.RowIndex][dic_.Key].ContainsKey(tables_show.Columns[e.ColumnIndex].HeaderText))
                        {
                            DgvSQL.rowsTruct[e.RowIndex][dic_.Key][tables_show.Columns[e.ColumnIndex].HeaderText] =
                                tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        }
                        //否则添加这一行的修改记录
                        else
                        {
                            DgvSQL.rowsTruct[e.RowIndex][dic_.Key].Add(tables_show.Columns[e.ColumnIndex].HeaderText,
                                tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                        }
                    }

                }
                //否则添加新一行的修改记录
                else
                {
                    Dictionary<string, Dictionary<string, string>> idToVolue = new Dictionary<string, Dictionary<string, string>>()
                    {
                        //嵌套一层，id+表结构
                        {DgvSQL.nowEditID, new Dictionary<string, string>(){
                            //第二层，表头表值
                            { tables_show.Columns[e.ColumnIndex].HeaderText,
                            tables_show.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()}
                        } }
                    };
                    DgvSQL.rowsTruct.Add(e.RowIndex, idToVolue);
                }
            }
            else if (tables_show.Rows.Count > DgvSQL.rowsCount)
            {
                //是否已经存在该行
                if (DgvSQL.newInsert.IndexOf(e.RowIndex) < 0)
                {
                    DgvSQL.newInsert.Add(e.RowIndex);
                }
            }
        }
        //*************表格右键操作*******************
        private void tables_show_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Button == MouseButtons.Left)
            {
                //获取主键索引
                int keys = tables_show.Columns[DgvSQL.primaryKeys[0]].Index;
                var columnVolue = tables_show.Rows[e.RowIndex].Cells[keys].Value;
                if (columnVolue != null)
                {
                    //获取主键值
                    DgvSQL.nowEditID = columnVolue.ToString();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                tables_show.ContextMenuStrip = table_Rclick;
            }
        }

        private void freash_grid_Click(object sender, EventArgs e)
        {
            DgvSQL.UpdataGrid(tables_show, string.Format("SELECT * FROM {0}.{1}", DgvSQL.database_and_table_names[0],
                DgvSQL.database_and_table_names[1]), Dbcon, messageText);
            DgvSQL.GetKeysName(Dbcon);
            //更换主键行颜色
            DgvSQL.changeColor(tables_show);
            //表格状态更新
            tables_show.ReadOnly = false;
            tables_show.AllowUserToAddRows = true;
        }

        private void delete_Rows_Click(object sender, EventArgs e)
        {
            try
            {
                int rmIndex = tables_show.SelectedRows[0].Index;
                if (DgvSQL.newInsert.IndexOf(rmIndex) > -1)
                {
                    DgvSQL.newInsert.Remove(rmIndex);
                }
                else
                {
                    int keys = tables_show.Columns[DgvSQL.primaryKeys[0]].Index;
                    DgvSQL.delRows.Add(string.Format("DELETE FROM `{0}`.`{1}` WHERE (`{2}` = '{3}');\r\n", DgvSQL.database_and_table_names[0],
                        DgvSQL.database_and_table_names[1], tables_show.Columns[0].HeaderText, tables_show.SelectedRows[0].Cells[keys].Value));
                }
                tables_show.Rows.Remove(tables_show.SelectedRows[0]);
                //刷新当前行数
                DgvSQL.rowsCount = tables_show.Rows.Count;
            }
            catch (Exception ex)
            {
                DgvSQL.showMessage(messageText, ex.Message, DgvSQL.ErrorCode.Error);
            }
        }
        //********************************************


    }
}
