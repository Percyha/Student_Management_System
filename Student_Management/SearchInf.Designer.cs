namespace Student_Management
{
    partial class SearchInf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchInf));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sno = new System.Windows.Forms.TextBox();
            this.button_SearchInf = new System.Windows.Forms.Button();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入查询学生的学号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Sno
            // 
            this.textBox_Sno.Location = new System.Drawing.Point(370, 64);
            this.textBox_Sno.Name = "textBox_Sno";
            this.textBox_Sno.Size = new System.Drawing.Size(227, 25);
            this.textBox_Sno.TabIndex = 1;
            this.textBox_Sno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_SearchInf
            // 
            this.button_SearchInf.AutoSize = true;
            this.button_SearchInf.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SearchInf.Location = new System.Drawing.Point(485, 132);
            this.button_SearchInf.Name = "button_SearchInf";
            this.button_SearchInf.Size = new System.Drawing.Size(112, 33);
            this.button_SearchInf.TabIndex = 2;
            this.button_SearchInf.Text = "确认";
            this.button_SearchInf.UseVisualStyleBackColor = true;
            this.button_SearchInf.Click += new System.EventHandler(this.button_SearchInf_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.AutoSize = true;
            this.button_Cancle.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancle.Location = new System.Drawing.Point(291, 132);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(112, 33);
            this.button_Cancle.TabIndex = 3;
            this.button_Cancle.Text = "取消";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // button_Back
            // 
            this.button_Back.AutoSize = true;
            this.button_Back.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Back.Location = new System.Drawing.Point(82, 132);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(135, 33);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "返回上一级";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // SearchInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 235);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.button_SearchInf);
            this.Controls.Add(this.textBox_Sno);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchInf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Sno;
        private System.Windows.Forms.Button button_SearchInf;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Button button_Back;
    }
}