﻿namespace Login_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 167);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(275, 164);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(260, 27);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 221);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 215);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(419, 319);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(116, 31);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDangNhap);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtPassword;
        private Button btnDangNhap;
    }
}