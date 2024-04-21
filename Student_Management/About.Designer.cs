namespace Student_Management
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.richTextBox_About = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_About
            // 
            this.richTextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_About.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_About.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_About.Name = "richTextBox_About";
            this.richTextBox_About.ReadOnly = true;
            this.richTextBox_About.Size = new System.Drawing.Size(552, 101);
            this.richTextBox_About.TabIndex = 0;
            this.richTextBox_About.Text = "1.明确使用目的，按照要求进行系统的使用\n2.可通过演示视频进行操作\n\t感谢您的使用！";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 101);
            this.Controls.Add(this.richTextBox_About);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_About;
    }
}