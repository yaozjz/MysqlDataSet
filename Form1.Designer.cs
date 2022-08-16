
namespace MySQLDataSet
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("数据库", 1, 0);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.msdb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addDB = new System.Windows.Forms.ToolStripButton();
            this.SqlScriptEdit = new System.Windows.Forms.ToolStripButton();
            this.closeBt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.freash_db = new System.Windows.Forms.ToolStripButton();
            this.database_tree = new System.Windows.Forms.TreeView();
            this.backsplit = new System.Windows.Forms.SplitContainer();
            this.leftSplit = new System.Windows.Forms.SplitContainer();
            this.statusText = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBt = new System.Windows.Forms.ToolStripStatusLabel();
            this.rightSplit = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tables_show = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apply = new System.Windows.Forms.Button();
            this.messageText = new System.Windows.Forms.DataGridView();
            this.times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.messageBt = new System.Windows.Forms.ToolStripStatusLabel();
            this.db_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_table = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.添加表单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deltable = new System.Windows.Forms.ToolStripMenuItem();
            this.msdb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backsplit)).BeginInit();
            this.backsplit.Panel1.SuspendLayout();
            this.backsplit.Panel2.SuspendLayout();
            this.backsplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplit)).BeginInit();
            this.leftSplit.Panel1.SuspendLayout();
            this.leftSplit.Panel2.SuspendLayout();
            this.leftSplit.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplit)).BeginInit();
            this.rightSplit.Panel1.SuspendLayout();
            this.rightSplit.Panel2.SuspendLayout();
            this.rightSplit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tables_show)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messageText)).BeginInit();
            this.statusStrip2.SuspendLayout();
            this.db_cms.SuspendLayout();
            this.tableRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // msdb
            // 
            this.msdb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.登录数据库ToolStripMenuItem});
            this.msdb.Name = "contextMenuStrip1";
            this.msdb.Size = new System.Drawing.Size(137, 48);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.fresh_db_Click);
            // 
            // 登录数据库ToolStripMenuItem
            // 
            this.登录数据库ToolStripMenuItem.Name = "登录数据库ToolStripMenuItem";
            this.登录数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.登录数据库ToolStripMenuItem.Text = "登录数据库";
            this.登录数据库ToolStripMenuItem.Click += new System.EventHandler(this.addDB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加数据库ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 添加数据库ToolStripMenuItem
            // 
            this.添加数据库ToolStripMenuItem.Name = "添加数据库ToolStripMenuItem";
            this.添加数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加数据库ToolStripMenuItem.Text = "添加数据库";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDB,
            this.SqlScriptEdit,
            this.closeBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addDB
            // 
            this.addDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addDB.Image = global::MySQLDataSet.Properties.Resources.add;
            this.addDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDB.Name = "addDB";
            this.addDB.Size = new System.Drawing.Size(23, 22);
            this.addDB.Text = "addDB";
            this.addDB.ToolTipText = "添加数据库";
            this.addDB.Click += new System.EventHandler(this.addDB_Click);
            // 
            // SqlScriptEdit
            // 
            this.SqlScriptEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SqlScriptEdit.Image = global::MySQLDataSet.Properties.Resources.write;
            this.SqlScriptEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SqlScriptEdit.Name = "SqlScriptEdit";
            this.SqlScriptEdit.Size = new System.Drawing.Size(23, 22);
            this.SqlScriptEdit.Text = "脚本编写";
            this.SqlScriptEdit.Click += new System.EventHandler(this.SqlScriptEdit_Click);
            // 
            // closeBt
            // 
            this.closeBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeBt.Image = global::MySQLDataSet.Properties.Resources.exit;
            this.closeBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeBt.Name = "closeBt";
            this.closeBt.Size = new System.Drawing.Size(23, 22);
            this.closeBt.Text = "退出";
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freash_db});
            this.toolStrip2.Location = new System.Drawing.Point(0, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(804, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // freash_db
            // 
            this.freash_db.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.freash_db.Image = global::MySQLDataSet.Properties.Resources.刷新;
            this.freash_db.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.freash_db.Name = "freash_db";
            this.freash_db.Size = new System.Drawing.Size(23, 22);
            this.freash_db.Text = "刷新数据库";
            this.freash_db.Click += new System.EventHandler(this.fresh_db_Click);
            // 
            // database_tree
            // 
            this.database_tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.database_tree.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.database_tree.Location = new System.Drawing.Point(0, 0);
            this.database_tree.Name = "database_tree";
            treeNode1.ContextMenuStrip = this.msdb;
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Alldb";
            treeNode1.SelectedImageIndex = 0;
            treeNode1.Text = "数据库";
            this.database_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.database_tree.Size = new System.Drawing.Size(157, 350);
            this.database_tree.TabIndex = 1;
            this.database_tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.database_tree_MouseClick);
            // 
            // backsplit
            // 
            this.backsplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backsplit.Location = new System.Drawing.Point(0, 75);
            this.backsplit.Name = "backsplit";
            // 
            // backsplit.Panel1
            // 
            this.backsplit.Panel1.Controls.Add(this.leftSplit);
            // 
            // backsplit.Panel2
            // 
            this.backsplit.Panel2.Controls.Add(this.rightSplit);
            this.backsplit.Size = new System.Drawing.Size(804, 481);
            this.backsplit.SplitterDistance = 157;
            this.backsplit.TabIndex = 6;
            // 
            // leftSplit
            // 
            this.leftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSplit.Location = new System.Drawing.Point(0, 0);
            this.leftSplit.Name = "leftSplit";
            this.leftSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftSplit.Panel1
            // 
            this.leftSplit.Panel1.Controls.Add(this.database_tree);
            // 
            // leftSplit.Panel2
            // 
            this.leftSplit.Panel2.Controls.Add(this.statusText);
            this.leftSplit.Panel2.Controls.Add(this.statusStrip1);
            this.leftSplit.Size = new System.Drawing.Size(157, 481);
            this.leftSplit.SplitterDistance = 350;
            this.leftSplit.TabIndex = 0;
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.Window;
            this.statusText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusText.Location = new System.Drawing.Point(0, 0);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(157, 105);
            this.statusText.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 105);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(157, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBt
            // 
            this.statusBt.BackColor = System.Drawing.SystemColors.Control;
            this.statusBt.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusBt.Name = "statusBt";
            this.statusBt.Size = new System.Drawing.Size(29, 17);
            this.statusBt.Text = "状态";
            // 
            // rightSplit
            // 
            this.rightSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplit.Location = new System.Drawing.Point(0, 0);
            this.rightSplit.Name = "rightSplit";
            this.rightSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightSplit.Panel1
            // 
            this.rightSplit.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // rightSplit.Panel2
            // 
            this.rightSplit.Panel2.Controls.Add(this.messageText);
            this.rightSplit.Panel2.Controls.Add(this.statusStrip2);
            this.rightSplit.Size = new System.Drawing.Size(643, 481);
            this.rightSplit.SplitterDistance = 307;
            this.rightSplit.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tables_show, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.50814F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.491857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tables_show
            // 
            this.tables_show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tables_show.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tables_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tables_show.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tables_show.Location = new System.Drawing.Point(0, 0);
            this.tables_show.Margin = new System.Windows.Forms.Padding(0);
            this.tables_show.Name = "tables_show";
            this.tables_show.RowTemplate.Height = 23;
            this.tables_show.Size = new System.Drawing.Size(643, 283);
            this.tables_show.TabIndex = 0;
            this.tables_show.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tables_show_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.apply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 24);
            this.panel1.TabIndex = 1;
            // 
            // apply
            // 
            this.apply.Dock = System.Windows.Forms.DockStyle.Right;
            this.apply.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apply.Location = new System.Drawing.Point(568, 0);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 24);
            this.apply.TabIndex = 0;
            this.apply.Text = "应用";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // messageText
            // 
            this.messageText.AllowUserToAddRows = false;
            this.messageText.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.messageText.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.messageText.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.messageText.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.messageText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.times,
            this.status,
            this.messages});
            this.messageText.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.messageText.DefaultCellStyle = dataGridViewCellStyle2;
            this.messageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageText.Location = new System.Drawing.Point(0, 0);
            this.messageText.Margin = new System.Windows.Forms.Padding(0);
            this.messageText.MultiSelect = false;
            this.messageText.Name = "messageText";
            this.messageText.ReadOnly = true;
            this.messageText.RowHeadersVisible = false;
            this.messageText.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.messageText.RowTemplate.Height = 23;
            this.messageText.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.messageText.Size = new System.Drawing.Size(643, 148);
            this.messageText.TabIndex = 1;
            this.messageText.TabStop = false;
            // 
            // times
            // 
            this.times.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.times.HeaderText = "时间";
            this.times.Name = "times";
            this.times.ReadOnly = true;
            this.times.Width = 62;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.FillWeight = 101.5228F;
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 62;
            // 
            // messages
            // 
            this.messages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messages.FillWeight = 98.47716F;
            this.messages.HeaderText = "消息";
            this.messages.Name = "messages";
            this.messages.ReadOnly = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageBt});
            this.statusStrip2.Location = new System.Drawing.Point(0, 148);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(643, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // messageBt
            // 
            this.messageBt.BackColor = System.Drawing.SystemColors.Control;
            this.messageBt.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageBt.Name = "messageBt";
            this.messageBt.Size = new System.Drawing.Size(29, 17);
            this.messageBt.Text = "消息";
            // 
            // db_cms
            // 
            this.db_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新数据库ToolStripMenuItem,
            this.add_table});
            this.db_cms.Name = "db_cms";
            this.db_cms.Size = new System.Drawing.Size(125, 48);
            // 
            // 刷新数据库ToolStripMenuItem
            // 
            this.刷新数据库ToolStripMenuItem.Name = "刷新数据库ToolStripMenuItem";
            this.刷新数据库ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新数据库ToolStripMenuItem.Text = "刷新";
            this.刷新数据库ToolStripMenuItem.Click += new System.EventHandler(this.fresh_db_Click);
            // 
            // add_table
            // 
            this.add_table.Name = "add_table";
            this.add_table.Size = new System.Drawing.Size(124, 22);
            this.add_table.Text = "添加表单";
            this.add_table.Click += new System.EventHandler(this.add_table_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "数据库";
            this.dataGridViewImageColumn1.Image = global::MySQLDataSet.Properties.Resources.database;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tableRightClick
            // 
            this.tableRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem1,
            this.添加表单ToolStripMenuItem,
            this.deltable});
            this.tableRightClick.Name = "tableRightClick";
            this.tableRightClick.Size = new System.Drawing.Size(125, 70);
            // 
            // 刷新ToolStripMenuItem1
            // 
            this.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1";
            this.刷新ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.刷新ToolStripMenuItem1.Text = "刷新";
            this.刷新ToolStripMenuItem1.Click += new System.EventHandler(this.fresh_db_Click);
            // 
            // 添加表单ToolStripMenuItem
            // 
            this.添加表单ToolStripMenuItem.Name = "添加表单ToolStripMenuItem";
            this.添加表单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加表单ToolStripMenuItem.Text = "添加表单";
            this.添加表单ToolStripMenuItem.Click += new System.EventHandler(this.add_table_Click);
            // 
            // deltable
            // 
            this.deltable.Name = "deltable";
            this.deltable.Size = new System.Drawing.Size(124, 22);
            this.deltable.Text = "删除表单";
            this.deltable.Click += new System.EventHandler(this.deltable_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 556);
            this.Controls.Add(this.backsplit);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "MySQL数据之眼";
            this.msdb.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.backsplit.Panel1.ResumeLayout(false);
            this.backsplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backsplit)).EndInit();
            this.backsplit.ResumeLayout(false);
            this.leftSplit.Panel1.ResumeLayout(false);
            this.leftSplit.Panel2.ResumeLayout(false);
            this.leftSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftSplit)).EndInit();
            this.leftSplit.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.rightSplit.Panel1.ResumeLayout(false);
            this.rightSplit.Panel2.ResumeLayout(false);
            this.rightSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplit)).EndInit();
            this.rightSplit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tables_show)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messageText)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.db_cms.ResumeLayout(false);
            this.tableRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addDB;
        private System.Windows.Forms.ToolStripButton closeBt;
        private System.Windows.Forms.ContextMenuStrip msdb;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton freash_db;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TreeView database_tree;
        private System.Windows.Forms.SplitContainer backsplit;
        private System.Windows.Forms.SplitContainer leftSplit;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBt;
        private System.Windows.Forms.SplitContainer rightSplit;
        private System.Windows.Forms.DataGridView tables_show;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel messageBt;
        private System.Windows.Forms.DataGridView messageText;
        private System.Windows.Forms.DataGridViewTextBoxColumn times;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn messages;
        private System.Windows.Forms.ContextMenuStrip db_cms;
        private System.Windows.Forms.ToolStripMenuItem 刷新数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_table;
        private System.Windows.Forms.ToolStripButton SqlScriptEdit;
        private System.Windows.Forms.ContextMenuStrip tableRightClick;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 添加表单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deltable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button apply;
    }
}

