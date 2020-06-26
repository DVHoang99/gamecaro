namespace caro
{
    partial class FormDangKi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRePassWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(166, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(194, 201);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(93, 64);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Đăng Kí";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(166, 115);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(345, 22);
            this.txtPassWord.TabIndex = 6;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(395, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 64);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Quay Lại Đăng Nhập";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtRePassWord
            // 
            this.txtRePassWord.Location = new System.Drawing.Point(166, 159);
            this.txtRePassWord.Name = "txtRePassWord";
            this.txtRePassWord.Size = new System.Drawing.Size(345, 22);
            this.txtRePassWord.TabIndex = 10;
            this.txtRePassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập Lại Mật Khẩu";
            // 
            // FormDangKi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 277);
            this.Controls.Add(this.txtRePassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "FormDangKi";
            this.Text = "Đăng kí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRePassWord;
        private System.Windows.Forms.Label label4;
    }
}