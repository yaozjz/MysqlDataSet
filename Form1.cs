using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
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
                        KeyWordHightLight.CommandAction(command, tables_show, messageText, Dbcon);
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

        private void closeBt_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
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
            EditScript(script);

        }

        private void deltable_Click(object sender, EventArgs e)
        {
            //删除表单
        }

        //脚本编辑器
        private void SqlScriptEdit_Click(object sender, EventArgs e)
        {
            EditScript(new showScript());
        }

        private void database_tree_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode select_node = database_tree.GetNodeAt(e.X, e.Y);
            //表单选择项过滤
            if (select_node.Level == 1)
            {
                //选中的是数据库
                database_tree.ContextMenuStrip = db_cms;
            }
            else if (select_node.Level == 2)
            {
                //选中的是表单
                database_tree.ContextMenuStrip = tableRightClick;
                DgvSQL dgvsql = new DgvSQL();
                dgvsql.fresh_table_grid(select_node, tables_show, Dbcon, messageText);
                tables_show.ReadOnly = false;
                tables_show.AllowUserToAddRows = true;
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
            DgvSQL.showMessage(messageText, string.Format("现有行{0}", tables_show.Rows.Count), DgvSQL.Msg);
        }

        private void tables_show_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void tables_show_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DgvSQL.showMessage(messageText, string.Format("更改的索引{0}", tables_show.Rows[e.RowIndex]), DgvSQL.Msg);
        }
    }
}
