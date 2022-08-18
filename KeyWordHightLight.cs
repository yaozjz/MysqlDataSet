using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MySQLDataSet
{
    class KeyWordHightLight
    {
        public static List<string> AllClass()
        {
            List<string> list = new List<string>();
            list.Add("select");
            list.Add("from");
            list.Add("show");
            list.Add("databases");
            list.Add("tables");
            list.Add("where");
            list.Add("group");
            list.Add("by");
            list.Add("limit");
            list.Add("having");
            list.Add("drop");
            list.Add("create");
            list.Add("if");
            list.Add("not");
            list.Add("INT");
            list.Add("varchar");
            list.Add("exists");
            list.Add("null");
            list.Add("insert");
            list.Add("into");
            list.Add("update");
            list.Add("delete");
            list.Add("TABLE");
            list.Add("PRIMARY");
            list.Add("key");
            list.Add("SCHEMA");
            list.Add("alter");
            list.Add("after");
            //list.Add("");
            return list;
        }
        public static string[] ExcludeList = { " ", ";", ",", "(", ")" };

        //关键字高亮关键函数
        private static void SHLFun(RichTextBox trb, Color c, int lineIndex, int foucusIndex)
        {
            int firstIndex = trb.GetFirstCharIndexFromLine(lineIndex);//当前行第一个字符索引
            string line = trb.Lines[lineIndex];     //获取当前行文本
            List<string> names = line.Split(ExcludeList, StringSplitOptions.RemoveEmptyEntries).ToList();//切割字符
            foreach (string word in names)
            {
                if (AllClass().FindIndex(x => x.Equals(word, StringComparison.OrdinalIgnoreCase)) > -1)
                {
                    int insertIndex = line.IndexOf(word) + firstIndex;
                    trb.Select(insertIndex, word.Length);
                    trb.SelectionColor = c;
                    trb.Select(foucusIndex, 0);
                    trb.SelectionColor = Color.Black;
                }
                else
                {
                    int insertIndex = line.IndexOf(word) + firstIndex;
                    trb.Select(insertIndex, word.Length);
                    trb.SelectionColor = Color.Black;
                    trb.Select(foucusIndex, 0);
                }
            }
        }
        //返回搜索字符串
        public static void SetHightLight(RichTextBox trb, Color c, int textLineHeight)
        {
            //获取当前光标索引
            int foucusIndex = trb.SelectionStart;

            if (trb.Lines.Length <= 0) return;
            int update_lines = trb.Lines.Length - textLineHeight;
            //获取当前行索引
            int lineIndex = trb.GetLineFromCharIndex(foucusIndex);
            if (update_lines > 1)
            {
                int counter = 0;
                while(counter < update_lines)
                {
                    SHLFun(trb, c, lineIndex - counter, foucusIndex);
                    counter++;
                }
            }
            else
            {
                SHLFun(trb, c, lineIndex, foucusIndex);
            }
        }
        /// <summary>
        /// 脚本执行程序之后的命令筛选
        /// </summary>
        /// <param name="command"></param>
        /// <param name="tables_show"></param>
        /// <param name="messageText"></param>
        /// <param name="Dbcon"></param>
        public static void CommandAction(string command, DataGridView tables_show, DataGridView messageText, MySqlConnection Dbcon)
        {
            if (command.IndexOf("show", StringComparison.OrdinalIgnoreCase) > -1)
            {
                DgvSQL.UpdataGrid(tables_show, command, Dbcon, messageText);
                tables_show.ReadOnly = true;
                tables_show.AllowUserToAddRows = false;
            }
            else if (command.IndexOf("select", StringComparison.OrdinalIgnoreCase) > -1)
            {
                DgvSQL.UpdataGrid(tables_show, command, Dbcon, messageText);
                tables_show.ReadOnly = false;
                tables_show.AllowUserToAddRows = true;
            }
            else
            {
                try
                {
                    var rt = mysqlDB.Exute(command, Dbcon);
                    if (rt != -1)
                    {
                        DgvSQL.showMessage(messageText, "成功:" + command, DgvSQL.ErrorCode.Ok);
                    }
                    else
                    {
                        DgvSQL.showMessage(messageText, "失败:" + command, DgvSQL.ErrorCode.Error);
                    }
                }catch(Exception ex)
                {
                    DgvSQL.showMessage(messageText, ex.Message, DgvSQL.ErrorCode.Error);
                }
            }
        }

        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="rtb"></param>
        /// <param name="panelLine"></param>
        public static void ShowLineOfText(RichTextBox rtb, Panel panelLine)
        {
            int crntFirstLine = 0;//第一行
            //最后一行坐标
            int crntLastIndex = rtb.TextLength;
            int crntLastLine = rtb.Lines.Length;//最后一行
            Point crntLastPos = rtb.GetPositionFromCharIndex(crntLastIndex);//最后一个字符的坐标
            //准备画图
            Graphics g = panelLine.CreateGraphics();
            Font font = new Font(rtb.Font, rtb.Font.Style);
            SolidBrush brush = new SolidBrush(panelLine.BackColor);
            //刷新画布
            g.FillRectangle(brush, 0, 0, panelLine.ClientRectangle.Width, panelLine.ClientRectangle.Height);
            brush.Color = Color.White;//重置画笔颜色

            int brushX = panelLine.ClientRectangle.Width - Convert.ToInt32(font.Size * 3);
            int brushY = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21f);
            if (crntLastLine > 0)
            {
                for (int i = crntLastLine; i > crntFirstLine; i--)
                {
                    g.DrawString((i).ToString(), font, brush, brushX, brushY);
                    brushY -= rtb.Font.Height;
                }
            }
            else
            {
                g.DrawString("1", font, brush, brushX, brushY);
            }
            g.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        /// <summary>
        /// 获取命令中的数据库以及表单名称
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static List<string> GetTableName(string command)
        {
            List<string> words = command.Split(ExcludeList, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach(string keyword in words)
            {
                if (keyword.IndexOf('.') > -1)
                {
                    List<string> result = keyword.Split('.').ToList();
                    return result;
                }
            }
            return new List<string>();
        }
    }
}