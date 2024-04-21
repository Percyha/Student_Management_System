namespace Student_Management
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sno = new System.Windows.Forms.TextBox();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入删除学生的学号";
            // 
            // textBox_Sno
            // 
            this.textBox_Sno.Location = new System.Drawing.Point(322, 70);
            this.textBox_Sno.Name = "textBox_Sno";
            this.textBox_Sno.Size = new System.Drawing.Size(169, 25);
            this.textBox_Sno.TabIndex = 1;
            this.textBox_Sno.TextChanged += new System.EventHandler(this.textBox_Sno_TextChanged);
            // 
            // button_Cancle
            // 
            this.button_Cancle.AutoSize = true;
            this.button_Cancle.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancle.Location = new System.Drawing.Point(80, 145);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(120, 36);
            this.button_Cancle.TabIndex = 2;
            this.button_Cancle.Text = "取消";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.AutoSize = true;
            this.button_confirm.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirm.Location = new System.Drawing.Point(322, 145);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(120, 36);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 223);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.textBox_Sno);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.Button button_confirm;
        internal System.Windows.Forms.TextBox textBox_Sno;
    }
}