namespace Student_Management
{
    partial class StuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuLogin));
            this.label_Titile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button1_Login = new System.Windows.Forms.Button();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Titile
            // 
            this.label_Titile.AutoSize = true;
            this.label_Titile.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Titile.Location = new System.Drawing.Point(151, 61);
            this.label_Titile.Name = "label_Titile";
            this.label_Titile.Size = new System.Drawing.Size(590, 70);
            this.label_Titile.TabIndex = 0;
            this.label_Titile.Text = "欢迎登录选课系统";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.textBox_Password);
            this.panel1.Controls.Add(this.button1_Login);
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label_Password);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Location = new System.Drawing.Point(156, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 242);
            this.panel1.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(205, 112);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(263, 25);
            this.textBox_Password.TabIndex = 5;
            // 
            // button1_Login
            // 
            this.button1_Login.AutoSize = true;
            this.button1_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1_Login.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_Login.Location = new System.Drawing.Point(113, 167);
            this.button1_Login.Name = "button1_Login";
            this.button1_Login.Size = new System.Drawing.Size(338, 43);
            this.button1_Login.TabIndex = 4;
            this.button1_Login.Text = "登录系统";
            this.button1_Login.UseVisualStyleBackColor = false;
            this.button1_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(205, 30);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(263, 25);
            this.textBox_Id.TabIndex = 2;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Password.Location = new System.Drawing.Point(3, 108);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(172, 23);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "交大ID账号密码";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(49, 32);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(126, 23);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "交大ID账号";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Titile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生登录选课系统界面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_Login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_Password;
        internal System.Windows.Forms.TextBox textBox_Id;
    }
}