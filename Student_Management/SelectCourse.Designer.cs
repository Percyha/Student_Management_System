namespace Student_Management
{
    partial class SelectCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCourse));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_ShowCourse = new System.Windows.Forms.ListView();
            this.columnHeader_Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Dept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Credict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Per = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回上一级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_AlCourse = new System.Windows.Forms.Button();
            this.button_SearchDetails = new System.Windows.Forms.Button();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.textBox_Diff = new System.Windows.Forms.TextBox();
            this.label_Diff = new System.Windows.Forms.Label();
            this.textBox_Just = new System.Windows.Forms.TextBox();
            this.label_Just = new System.Windows.Forms.Label();
            this.textBox_Cre = new System.Windows.Forms.TextBox();
            this.label_Cre = new System.Windows.Forms.Label();
            this.textBox_Dept = new System.Windows.Forms.TextBox();
            this.label_Dept = new System.Windows.Forms.Label();
            this.textBox_Tea = new System.Windows.Forms.TextBox();
            this.label_Tea = new System.Windows.Forms.Label();
            this.label_Cname = new System.Windows.Forms.Label();
            this.textBox_Cname = new System.Windows.Forms.TextBox();
            this.contextMenuStri_LvQuickClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_LtQuickClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查询SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStri_LvQuickClick.SuspendLayout();
            this.contextMenuStrip_LtQuickClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 500);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listView_ShowCourse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39669F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.6033F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 219);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView_ShowCourse
            // 
            this.listView_ShowCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Code,
            this.columnHeader_No,
            this.columnHeader_Name,
            this.columnHeader_Dept,
            this.columnHeader_Teacher,
            this.columnHeader_Credict,
            this.columnHeader_Per});
            this.listView_ShowCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ShowCourse.FullRowSelect = true;
            this.listView_ShowCourse.GridLines = true;
            this.listView_ShowCourse.HideSelection = false;
            this.listView_ShowCourse.Location = new System.Drawing.Point(3, 30);
            this.listView_ShowCourse.Name = "listView_ShowCourse";
            this.listView_ShowCourse.Size = new System.Drawing.Size(893, 186);
            this.listView_ShowCourse.TabIndex = 0;
            this.listView_ShowCourse.UseCompatibleStateImageBehavior = false;
            this.listView_ShowCourse.View = System.Windows.Forms.View.Details;
            this.listView_ShowCourse.SelectedIndexChanged += new System.EventHandler(this.listView_ShowCourse_SelectedIndexChanged);
            this.listView_ShowCourse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_ShowCourse_MouseDown);
            this.listView_ShowCourse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_ShowCourse_MouseUp);
            // 
            // columnHeader_Code
            // 
            this.columnHeader_Code.Text = "选课代码";
            this.columnHeader_Code.Width = 109;
            // 
            // columnHeader_No
            // 
            this.columnHeader_No.Text = "课程代码";
            this.columnHeader_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_No.Width = 105;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "课程名称";
            this.columnHeader_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Name.Width = 96;
            // 
            // columnHeader_Dept
            // 
            this.columnHeader_Dept.Text = "开课学院";
            this.columnHeader_Dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Dept.Width = 111;
            // 
            // columnHeader_Teacher
            // 
            this.columnHeader_Teacher.Text = "开课老师";
            this.columnHeader_Teacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Teacher.Width = 100;
            // 
            // columnHeader_Credict
            // 
            this.columnHeader_Credict.Text = "学分";
            this.columnHeader_Credict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Credict.Width = 95;
            // 
            // columnHeader_Per
            // 
            this.columnHeader_Per.Text = "课程性质";
            this.columnHeader_Per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Per.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回上一级ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回上一级ToolStripMenuItem
            // 
            this.返回上一级ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("返回上一级ToolStripMenuItem.Image")));
            this.返回上一级ToolStripMenuItem.Name = "返回上一级ToolStripMenuItem";
            this.返回上一级ToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.返回上一级ToolStripMenuItem.Text = "返回上一级(B)";
            this.返回上一级ToolStripMenuItem.Click += new System.EventHandler(this.返回上一级ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("帮助HToolStripMenuItem.Image")));
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(95, 23);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            this.帮助HToolStripMenuItem.Click += new System.EventHandler(this.帮助HToolStripMenuItem_Click);
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("内容CToolStripMenuItem.Image")));
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            this.内容CToolStripMenuItem.Click += new System.EventHandler(this.内容CToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(152, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于AToolStripMenuItem.Image")));
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_Search, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_AlCourse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_SearchDetails, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_Cancle, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button_Add, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(660, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 245);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // button_Search
            // 
            this.button_Search.AutoSize = true;
            this.button_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Search.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.Location = new System.Drawing.Point(3, 3);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(217, 43);
            this.button_Search.TabIndex = 0;
            this.button_Search.Text = "查询可选课程信息";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            this.button_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Search_MouseClick);
            // 
            // button_AlCourse
            // 
            this.button_AlCourse.AutoSize = true;
            this.button_AlCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AlCourse.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AlCourse.Location = new System.Drawing.Point(3, 52);
            this.button_AlCourse.Name = "button_AlCourse";
            this.button_AlCourse.Size = new System.Drawing.Size(217, 43);
            this.button_AlCourse.TabIndex = 4;
            this.button_AlCourse.Text = "查询已选课程信息";
            this.button_AlCourse.UseVisualStyleBackColor = true;
            this.button_AlCourse.Click += new System.EventHandler(this.button_AlCourse_Click);
            this.button_AlCourse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_AlCourse_MouseClick);
            // 
            // button_SearchDetails
            // 
            this.button_SearchDetails.AutoSize = true;
            this.button_SearchDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SearchDetails.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SearchDetails.Location = new System.Drawing.Point(3, 101);
            this.button_SearchDetails.Name = "button_SearchDetails";
            this.button_SearchDetails.Size = new System.Drawing.Size(217, 43);
            this.button_SearchDetails.TabIndex = 7;
            this.button_SearchDetails.Text = "查询课程详细信息";
            this.button_SearchDetails.UseVisualStyleBackColor = true;
            this.button_SearchDetails.Click += new System.EventHandler(this.button_SearchDetails_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.AutoSize = true;
            this.button_Cancle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancle.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancle.Location = new System.Drawing.Point(3, 199);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(217, 43);
            this.button_Cancle.TabIndex = 6;
            this.button_Cancle.Text = "删除课程";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Add.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Add.Location = new System.Drawing.Point(3, 150);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(217, 43);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "添加课程";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            this.button_Add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Add_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.textBox_Year);
            this.groupBox1.Controls.Add(this.label_Year);
            this.groupBox1.Controls.Add(this.textBox_Diff);
            this.groupBox1.Controls.Add(this.label_Diff);
            this.groupBox1.Controls.Add(this.textBox_Just);
            this.groupBox1.Controls.Add(this.label_Just);
            this.groupBox1.Controls.Add(this.textBox_Cre);
            this.groupBox1.Controls.Add(this.label_Cre);
            this.groupBox1.Controls.Add(this.textBox_Dept);
            this.groupBox1.Controls.Add(this.label_Dept);
            this.groupBox1.Controls.Add(this.textBox_Tea);
            this.groupBox1.Controls.Add(this.label_Tea);
            this.groupBox1.Controls.Add(this.label_Cname);
            this.groupBox1.Controls.Add(this.textBox_Cname);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程具体信息";
            // 
            // textBox_Year
            // 
            this.textBox_Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Year.Location = new System.Drawing.Point(121, 166);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(202, 27);
            this.textBox_Year.TabIndex = 14;
            this.textBox_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Year.Location = new System.Drawing.Point(6, 173);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(109, 20);
            this.label_Year.TabIndex = 13;
            this.label_Year.Text = "已开课年份";
            // 
            // textBox_Diff
            // 
            this.textBox_Diff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Diff.Location = new System.Drawing.Point(440, 123);
            this.textBox_Diff.Name = "textBox_Diff";
            this.textBox_Diff.Size = new System.Drawing.Size(202, 27);
            this.textBox_Diff.TabIndex = 12;
            this.textBox_Diff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Diff
            // 
            this.label_Diff.AutoSize = true;
            this.label_Diff.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Diff.Location = new System.Drawing.Point(335, 123);
            this.label_Diff.Name = "label_Diff";
            this.label_Diff.Size = new System.Drawing.Size(89, 20);
            this.label_Diff.TabIndex = 11;
            this.label_Diff.Text = "课程难度";
            // 
            // textBox_Just
            // 
            this.textBox_Just.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Just.Location = new System.Drawing.Point(121, 120);
            this.textBox_Just.Name = "textBox_Just";
            this.textBox_Just.Size = new System.Drawing.Size(202, 27);
            this.textBox_Just.TabIndex = 10;
            this.textBox_Just.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Just
            // 
            this.label_Just.AutoSize = true;
            this.label_Just.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Just.Location = new System.Drawing.Point(6, 126);
            this.label_Just.Name = "label_Just";
            this.label_Just.Size = new System.Drawing.Size(89, 20);
            this.label_Just.TabIndex = 9;
            this.label_Just.Text = "课程评分";
            // 
            // textBox_Cre
            // 
            this.textBox_Cre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Cre.Location = new System.Drawing.Point(440, 82);
            this.textBox_Cre.Name = "textBox_Cre";
            this.textBox_Cre.Size = new System.Drawing.Size(202, 27);
            this.textBox_Cre.TabIndex = 8;
            this.textBox_Cre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Cre
            // 
            this.label_Cre.AutoSize = true;
            this.label_Cre.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Cre.Location = new System.Drawing.Point(335, 85);
            this.label_Cre.Name = "label_Cre";
            this.label_Cre.Size = new System.Drawing.Size(89, 20);
            this.label_Cre.TabIndex = 7;
            this.label_Cre.Text = "课程学分";
            // 
            // textBox_Dept
            // 
            this.textBox_Dept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Dept.Location = new System.Drawing.Point(121, 79);
            this.textBox_Dept.Name = "textBox_Dept";
            this.textBox_Dept.Size = new System.Drawing.Size(202, 27);
            this.textBox_Dept.TabIndex = 6;
            this.textBox_Dept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Dept
            // 
            this.label_Dept.AutoSize = true;
            this.label_Dept.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Dept.Location = new System.Drawing.Point(6, 82);
            this.label_Dept.Name = "label_Dept";
            this.label_Dept.Size = new System.Drawing.Size(89, 20);
            this.label_Dept.TabIndex = 5;
            this.label_Dept.Text = "开课学院";
            // 
            // textBox_Tea
            // 
            this.textBox_Tea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Tea.Location = new System.Drawing.Point(440, 43);
            this.textBox_Tea.Name = "textBox_Tea";
            this.textBox_Tea.Size = new System.Drawing.Size(202, 27);
            this.textBox_Tea.TabIndex = 4;
            this.textBox_Tea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Tea
            // 
            this.label_Tea.AutoSize = true;
            this.label_Tea.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Tea.Location = new System.Drawing.Point(335, 46);
            this.label_Tea.Name = "label_Tea";
            this.label_Tea.Size = new System.Drawing.Size(89, 20);
            this.label_Tea.TabIndex = 3;
            this.label_Tea.Text = "授课老师";
            // 
            // label_Cname
            // 
            this.label_Cname.AutoSize = true;
            this.label_Cname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Cname.Location = new System.Drawing.Point(6, 40);
            this.label_Cname.Name = "label_Cname";
            this.label_Cname.Size = new System.Drawing.Size(89, 20);
            this.label_Cname.TabIndex = 1;
            this.label_Cname.Text = "课程名称";
            // 
            // textBox_Cname
            // 
            this.textBox_Cname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Cname.Location = new System.Drawing.Point(121, 39);
            this.textBox_Cname.Name = "textBox_Cname";
            this.textBox_Cname.Size = new System.Drawing.Size(202, 27);
            this.textBox_Cname.TabIndex = 2;
            this.textBox_Cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStri_LvQuickClick
            // 
            this.contextMenuStri_LvQuickClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStri_LvQuickClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加AToolStripMenuItem,
            this.删除CToolStripMenuItem});
            this.contextMenuStri_LvQuickClick.Name = "contextMenuStri_LvQuickClick";
            this.contextMenuStri_LvQuickClick.Size = new System.Drawing.Size(130, 52);
            this.contextMenuStri_LvQuickClick.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStri_LvQuickClick_Opening);
            // 
            // 添加AToolStripMenuItem
            // 
            this.添加AToolStripMenuItem.Name = "添加AToolStripMenuItem";
            this.添加AToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.添加AToolStripMenuItem.Text = "添加(A)";
            this.添加AToolStripMenuItem.Click += new System.EventHandler(this.添加AToolStripMenuItem_Click);
            // 
            // 删除CToolStripMenuItem
            // 
            this.删除CToolStripMenuItem.Name = "删除CToolStripMenuItem";
            this.删除CToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.删除CToolStripMenuItem.Text = "查询(S)";
            this.删除CToolStripMenuItem.Click += new System.EventHandler(this.删除CToolStripMenuItem_Click);
            // 
            // contextMenuStrip_LtQuickClick
            // 
            this.contextMenuStrip_LtQuickClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_LtQuickClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询SToolStripMenuItem,
            this.删除CToolStripMenuItem1});
            this.contextMenuStrip_LtQuickClick.Name = "contextMenuStrip_LtQuickClick";
            this.contextMenuStrip_LtQuickClick.Size = new System.Drawing.Size(129, 52);
            // 
            // 查询SToolStripMenuItem
            // 
            this.查询SToolStripMenuItem.Name = "查询SToolStripMenuItem";
            this.查询SToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.查询SToolStripMenuItem.Text = "查询(S)";
            this.查询SToolStripMenuItem.Click += new System.EventHandler(this.查询SToolStripMenuItem_Click);
            // 
            // 删除CToolStripMenuItem1
            // 
            this.删除CToolStripMenuItem1.Name = "删除CToolStripMenuItem1";
            this.删除CToolStripMenuItem1.Size = new System.Drawing.Size(128, 24);
            this.删除CToolStripMenuItem1.Text = "删除(C)";
            this.删除CToolStripMenuItem1.Click += new System.EventHandler(this.删除CToolStripMenuItem1_Click_1);
            // 
            // SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(899, 500);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生选课系统";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStri_LvQuickClick.ResumeLayout(false);
            this.contextMenuStrip_LtQuickClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView_ShowCourse;
        private System.Windows.Forms.ColumnHeader columnHeader_Code;
        private System.Windows.Forms.ColumnHeader columnHeader_No;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Dept;
        private System.Windows.Forms.ColumnHeader columnHeader_Teacher;
        private System.Windows.Forms.ColumnHeader columnHeader_Credict;
        private System.Windows.Forms.ColumnHeader columnHeader_Per;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStri_LvQuickClick;
        private System.Windows.Forms.ToolStripMenuItem 添加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除CToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Cname;
        private System.Windows.Forms.TextBox textBox_Cname;
        private System.Windows.Forms.TextBox textBox_Diff;
        private System.Windows.Forms.Label label_Diff;
        private System.Windows.Forms.TextBox textBox_Just;
        private System.Windows.Forms.Label label_Just;
        private System.Windows.Forms.TextBox textBox_Cre;
        private System.Windows.Forms.Label label_Cre;
        private System.Windows.Forms.TextBox textBox_Dept;
        private System.Windows.Forms.Label label_Dept;
        private System.Windows.Forms.TextBox textBox_Tea;
        private System.Windows.Forms.Label label_Tea;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_AlCourse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_LtQuickClick;
        private System.Windows.Forms.ToolStripMenuItem 查询SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除CToolStripMenuItem1;
        private System.Windows.Forms.Button button_SearchDetails;
        private System.Windows.Forms.ToolStripMenuItem 返回上一级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}