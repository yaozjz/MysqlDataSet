
namespace MySQLDataSet
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.port_text = new System.Windows.Forms.TextBox();
            this.userName_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwd_text = new System.Windows.Forms.TextBox();
            this.canselbt = new System.Windows.Forms.Button();
            this.okbt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.database_text = new System.Windows.Forms.TextBox();
            this.saveBt = new System.Windows.Forms.CheckBox();
            this.showpasswd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "IP地址：";
            // 
            // ip_text
            // 
            this.ip_text.Location = new System.Drawing.Point(90, 28);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(180, 23);
            this.ip_text.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(276, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "端口：";
            // 
            // port_text
            // 
            this.port_text.Location = new System.Drawing.Point(329, 28);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(77, 23);
            this.port_text.TabIndex = 2;
            // 
            // userName_text
            // 
            this.userName_text.Location = new System.Drawing.Point(90, 79);
            this.userName_text.Name = "userName_text";
            this.userName_text.Size = new System.Drawing.Size(180, 23);
            this.userName_text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "密码：";
            // 
            // passwd_text
            // 
            this.passwd_text.Location = new System.Drawing.Point(90, 124);
            this.passwd_text.Name = "passwd_text";
            this.passwd_text.PasswordChar = '*';
            this.passwd_text.Size = new System.Drawing.Size(180, 23);
            this.passwd_text.TabIndex = 4;
            // 
            // canselbt
            // 
            this.canselbt.Location = new System.Drawing.Point(322, 179);
            this.canselbt.Name = "canselbt";
            this.canselbt.Size = new System.Drawing.Size(82, 23);
            this.canselbt.TabIndex = 7;
            this.canselbt.Text = "取消";
            this.canselbt.UseVisualStyleBackColor = true;
            this.canselbt.Click += new System.EventHandler(this.canselbt_Click);
            // 
            // okbt
            // 
            this.okbt.Location = new System.Drawing.Point(322, 142);
            this.okbt.Name = "okbt";
            this.okbt.Size = new System.Drawing.Size(82, 23);
            this.okbt.TabIndex = 6;
            this.okbt.Text = "确认";
            this.okbt.UseVisualStyleBackColor = true;
            this.okbt.Click += new System.EventHandler(this.okbt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "默认数据库：";
            // 
            // database_text
            // 
            this.database_text.Location = new System.Drawing.Point(113, 170);
            this.database_text.Name = "database_text";
            this.database_text.Size = new System.Drawing.Size(157, 23);
            this.database_text.TabIndex = 5;
            // 
            // saveBt
            // 
            this.saveBt.AutoSize = true;
            this.saveBt.Checked = true;
            this.saveBt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveBt.Location = new System.Drawing.Point(322, 79);
            this.saveBt.Name = "saveBt";
            this.saveBt.Size = new System.Drawing.Size(82, 18);
            this.saveBt.TabIndex = 8;
            this.saveBt.Text = "保存数据";
            this.saveBt.UseVisualStyleBackColor = true;
            // 
            // showpasswd
            // 
            this.showpasswd.AutoSize = true;
            this.showpasswd.Location = new System.Drawing.Point(322, 106);
            this.showpasswd.Name = "showpasswd";
            this.showpasswd.Size = new System.Drawing.Size(82, 18);
            this.showpasswd.TabIndex = 9;
            this.showpasswd.Text = "显示密码";
            this.showpasswd.UseVisualStyleBackColor = true;
            this.showpasswd.CheckedChanged += new System.EventHandler(this.showpasswd_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 214);
            this.Controls.Add(this.showpasswd);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.database_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.okbt);
            this.Controls.Add(this.canselbt);
            this.Controls.Add(this.passwd_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userName_text);
            this.Controls.Add(this.port_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ip_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button canselbt;
        private System.Windows.Forms.Button okbt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox saveBt;
        private System.Windows.Forms.CheckBox showpasswd;
        public System.Windows.Forms.TextBox ip_text;
        public System.Windows.Forms.TextBox port_text;
        public System.Windows.Forms.TextBox userName_text;
        public System.Windows.Forms.TextBox passwd_text;
        public System.Windows.Forms.TextBox database_text;
    }
}