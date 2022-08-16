using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLDataSet
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            ip_text.Text = ConfigurationManager.AppSettings["server"];
            port_text.Text = ConfigurationManager.AppSettings["port"];
            userName_text.Text = ConfigurationManager.AppSettings["user"];
            passwd_text.Text = ConfigurationManager.AppSettings["passwd"];
            database_text.Text = ConfigurationManager.AppSettings["database"];
        }

        private void okbt_Click(object sender, EventArgs e)
        {
            if (passwd_text.Text == "")
            {
                MessageBox.Show("请检查是否有空项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (saveBt.Checked)
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["server"].Value = ip_text.Text;
                    config.AppSettings.Settings["port"].Value = port_text.Text;
                    config.AppSettings.Settings["user"].Value = userName_text.Text;
                    config.AppSettings.Settings["passwd"].Value = passwd_text.Text;
                    config.AppSettings.Settings["database"].Value = database_text.Text;
                    config.AppSettings.SectionInformation.ForceSave = true;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void canselbt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void showpasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswd.Checked)
            {
                passwd_text.PasswordChar = new char();
            }
            else
            {
                passwd_text.PasswordChar = '*';
            }
        }
    }
}
