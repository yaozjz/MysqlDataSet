using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MySQLDataSet
{
    class DgvSQL
    {
        public enum ErrorCode { Ok = 0, Error = 1, Msg = 2 };
        public static List<string> database_and_table_names = new List<string>();
        public static int rowsCount = 0;

        //表单结构
        //索引值->表头->表值
        //插入
        public static List<int> newInsert = new List<int>();
        //删除
        public static List<string> delRows = new List<string>();
        //当前修改的原ID
        public static string nowEditID = "";
        //索引值->id值->表头->表值
        public static Dictionary<int, Dictionary<string, Dictionary<string, string>>> rowsTruct = 
            new Dictionary<int, Dictionary<string, Dictionary<string, string>>>();

        //获取主键索引及名称
        public static List<string> primaryKeys = new List<string>();

        public static void GetKeysName(MySqlConnection Dbcon)
        {
            primaryKeys.Clear();
            string sqlStr = string.Format("SHOW KEYS FROM `{0}`.`{1}`;", database_and_table_names[0], database_and_table_names[1]);
            var dr = mysqlDB.read(sqlStr, Dbcon);
            while (dr.Read())
            {
                primaryKeys.Add(dr[4].ToString());
            }
            dr.Close();
        }

        //更改某一列的颜色
        public static void changeColor(DataGridView dgv)
        {
            foreach(string colName in primaryKeys)
            {
                int colIndex = dgv.Columns[colName].Index;
                dgv.Columns[colIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }            
        }

        /// <summary>
        /// 表单刷新
        /// </summary>
        /// <param name="Tv"></param>
        /// <param name="Dgv"></param>
        /// <param name="Dbcon"></param>
        /// <param name="messageText"></param>
        public static void fresh_table_grid(TreeNode Tv, DataGridView Dgv, MySqlConnection Dbcon, DataGridView messageText)
        {
            Dgv.DataSource = null;
            string sqlStr = string.Format("SELECT * FROM {0}.{1}", Tv.Parent.Text, Tv.Text);
            UpdataGrid(Dgv, sqlStr, Dbcon, messageText);
            //更新主键名称
            GetKeysName(Dbcon);
            changeColor(Dgv);
        }

        public static void UpdataGrid(DataGridView Dgv, string command, MySqlConnection Dbcon, DataGridView messageText)
        {
            Dgv.DataSource = null;
            var rt = mysqlDB.command(command + ";", Dbcon);
            List<string> vs = KeyWordHightLight.GetTableName(command);
            if (vs.Any())
            {
                database_and_table_names = vs;
            }
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(rt);
                DataSet ds = new DataSet();
                sda.Fill(ds, "t");
                //Dgv.EditMode = DataGridViewEditMode.EditOnEnter;//单击单元格编辑
                Dgv.DataSource = ds.Tables["t"];
                //更新当前表格行数
                rowsCount = Dgv.Rows.Count;
                showMessage(messageText, command, ErrorCode.Ok);
            }
            catch (Exception ex)
            {
                showMessage(messageText, ex.Message, ErrorCode.Error);
            }
            //清除之前的记录
            rowsTruct.Clear();//update
            newInsert.Clear();//insert
            delRows.Clear();//delete
            rt.Dispose();
        }

        /// <summary>
        /// 信息显示
        /// </summary>
        /// <param name="messageText">对象指向一个DataGridView控件</param>
        /// <param name="msg"></param>
        /// <param name="ErrorCode">0为ok，1为Error</param>
        public static void showMessage(DataGridView messageText, string msg, ErrorCode ec)
        {
            if ((int)ec == 0)
            {
                string[] mssg = { DateTime.Now.ToString("HH:mm:ss"), "ok", msg };
                messageText.Rows.Add(mssg);
                messageText.Rows[messageText.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Green;
            }
            else if ((int)ec == 1)
            {
                string[] mssg = { DateTime.Now.ToString("HH:mm:ss"), "Error", msg };
                messageText.Rows.Add(mssg);
                messageText.Rows[messageText.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            }
            else if ((int)ec == 2)
            {
                string[] mssg = { DateTime.Now.ToString("HH:mm:ss"), "消息", msg };
                messageText.Rows.Add(mssg);
            }
            messageText.ClearSelection();
        }

        /// <summary>
        /// 数据库刷新
        /// 树状图刷新
        /// </summary>
        public static void DBshow(MySqlConnection Dbcon, TreeView Tv)
        {
            Tv.Nodes[0].Nodes.Clear();
            string sql = String.Format("SHOW DATABASES;");
            var dr = mysqlDB.read(sql, Dbcon);
            int count = 0;
            while (dr.Read())
            {
                if (count == 0)
                {
                    count++;
                    continue;
                }
                string db_name = dr[0].ToString();
                Tv.Nodes[0].Nodes.Add(new TreeNode(db_name));
            }
            dr.Close();
            count = 0;
            foreach (TreeNode tNode in Tv.Nodes[0].Nodes)
            {
                string ms1 = String.Format("SHOW TABLES FROM " + tNode.Text + ";");
                var dr2 = mysqlDB.read(ms1, Dbcon);
                while (dr2.Read())
                {
                    Tv.Nodes[0].Nodes[count].Nodes.Add(new TreeNode(dr2[0].ToString()));
                }
                count++;
                dr2.Close();
            }
        }


    }
}
