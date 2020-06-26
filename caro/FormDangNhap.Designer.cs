namespace caro
{
    partial class FormDangNhap
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
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSUp = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(152, 117);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(345, 22);
            this.txtPassWord.TabIndex = 8;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 22);
            this.txtUserName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // btnSUp
            // 
            this.btnSUp.Location = new System.Drawing.Point(408, 175);
            this.btnSUp.Name = "btnSUp";
            this.btnSUp.Size = new System.Drawing.Size(89, 47);
            this.btnSUp.TabIndex = 12;
            this.btnSUp.Text = "Đăng Kí";
            this.btnSUp.UseVisualStyleBackColor = true;
            this.btnSUp.Click += new System.EventHandler(this.btnSUp_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(152, 175);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(89, 47);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Đăng Nhập";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 262);
            this.Controls.Add(this.btnSUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label3);
            this.Name = "FormDangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSUp;
        private System.Windows.Forms.Button btnSignUp;
    }
}