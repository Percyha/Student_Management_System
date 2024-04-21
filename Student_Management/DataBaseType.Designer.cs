namespace Student_Management
{
    partial class DataBaseType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseType));
            this.comboBox_choseIdenty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_choseIdenty
            // 
            this.comboBox_choseIdenty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_choseIdenty.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_choseIdenty.FormattingEnabled = true;
            this.comboBox_choseIdenty.Items.AddRange(new object[] {
            "老师",
            "学生"});
            this.comboBox_choseIdenty.Location = new System.Drawing.Point(191, 199);
            this.comboBox_choseIdenty.Name = "comboBox_choseIdenty";
            this.comboBox_choseIdenty.Size = new System.Drawing.Size(255, 31);
            this.comboBox_choseIdenty.TabIndex = 0;
            this.comboBox_choseIdenty.Text = "请选择登录身份";
            this.comboBox_choseIdenty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(135, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用！";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBaseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_choseIdenty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataBaseType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录身份选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_choseIdenty;
        private System.Windows.Forms.Label label1;
    }
}