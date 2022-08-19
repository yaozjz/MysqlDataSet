
namespace MySQLDataSet
{
    partial class AddTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backGrid = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.schema = new System.Windows.Forms.Label();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBt = new System.Windows.Forms.Button();
            this.OkBt = new System.Windows.Forms.Button();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.primaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NotNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uniqueIndex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unsignedDataType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableRightBt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delRows = new System.Windows.Forms.ToolStripMenuItem();
            this.backGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableRightBt.SuspendLayout();
            this.SuspendLayout();
            // 
            // backGrid
            // 
            this.backGrid.ColumnCount = 1;
            this.backGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backGrid.Controls.Add(this.panel1, 0, 0);
            this.backGrid.Controls.Add(this.tableData, 0, 1);
            this.backGrid.Controls.Add(this.panel2, 0, 2);
            this.backGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGrid.Location = new System.Drawing.Point(0, 0);
            this.backGrid.Name = "backGrid";
            this.backGrid.RowCount = 3;
            this.backGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.backGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.backGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.backGrid.Size = new System.Drawing.Size(726, 304);
            this.backGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.schema);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名：";
            // 
            // tableName
            // 
            this.tableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableName.Location = new System.Drawing.Point(82, 20);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(149, 23);
            this.tableName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标数据库：";
            // 
            // schema
            // 
            this.schema.AutoSize = true;
            this.schema.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.schema.Location = new System.Drawing.Point(447, 23);
            this.schema.Name = "schema";
            this.schema.Size = new System.Drawing.Size(39, 14);
            this.schema.TabIndex = 3;
            this.schema.Text = "NULL";
            // 
            // tableData
            // 
            this.tableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.dataType,
            this.primaryKey,
            this.NotNull,
            this.uniqueIndex,
            this.unsignedDataType});
            this.tableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableData.Location = new System.Drawing.Point(0, 58);
            this.tableData.Margin = new System.Windows.Forms.Padding(0);
            this.tableData.Name = "tableData";
            this.tableData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableData.RowTemplate.Height = 23;
            this.tableData.Size = new System.Drawing.Size(726, 216);
            this.tableData.TabIndex = 1;
            this.tableData.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableData_CellMouseUp);
            this.tableData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tableData_RowsAdded);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.OkBt);
            this.panel2.Controls.Add(this.CancelBt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 30);
            this.panel2.TabIndex = 2;
            // 
            // CancelBt
            // 
            this.CancelBt.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBt.Location = new System.Drawing.Point(651, 0);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 30);
            this.CancelBt.TabIndex = 0;
            this.CancelBt.Text = "取消";
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // OkBt
            // 
            this.OkBt.Dock = System.Windows.Forms.DockStyle.Right;
            this.OkBt.Location = new System.Drawing.Point(576, 0);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(75, 30);
            this.OkBt.TabIndex = 1;
            this.OkBt.Text = "确定";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // ColName
            // 
            this.ColName.HeaderText = "列名";
            this.ColName.Name = "ColName";
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataType
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataType.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataType.HeaderText = "数据类型";
            this.dataType.Items.AddRange(new object[] {
            "INT",
            "VARCHAR(45)"});
            this.dataType.Name = "dataType";
            this.dataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // primaryKey
            // 
            this.primaryKey.HeaderText = "主键";
            this.primaryKey.Name = "primaryKey";
            // 
            // NotNull
            // 
            this.NotNull.HeaderText = "非空";
            this.NotNull.Name = "NotNull";
            // 
            // uniqueIndex
            // 
            this.uniqueIndex.HeaderText = "唯一索引";
            this.uniqueIndex.Name = "uniqueIndex";
            // 
            // unsignedDataType
            // 
            this.unsignedDataType.HeaderText = "无符号数据类型";
            this.unsignedDataType.Name = "unsignedDataType";
            // 
            // tableRightBt
            // 
            this.tableRightBt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delRows});
            this.tableRightBt.Name = "tableRightBt";
            this.tableRightBt.Size = new System.Drawing.Size(125, 26);
            // 
            // delRows
            // 
            this.delRows.Name = "delRows";
            this.delRows.Size = new System.Drawing.Size(180, 22);
            this.delRows.Text = "删除该列";
            this.delRows.Click += new System.EventHandler(this.delRows_Click);
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 304);
            this.Controls.Add(this.backGrid);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "AddTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加新表格";
            this.backGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableRightBt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel backGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label schema;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView tableData;
        public System.Windows.Forms.TextBox tableName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn primaryKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uniqueIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn unsignedDataType;
        private System.Windows.Forms.ContextMenuStrip tableRightBt;
        private System.Windows.Forms.ToolStripMenuItem delRows;
    }
}