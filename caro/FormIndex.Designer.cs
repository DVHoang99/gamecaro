namespace caro
{
    partial class FormIndex
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
            this.btnPvC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPvC
            // 
            this.btnPvC.Location = new System.Drawing.Point(55, 394);
            this.btnPvC.Name = "btnPvC";
            this.btnPvC.Size = new System.Drawing.Size(332, 97);
            this.btnPvC.TabIndex = 4;
            this.btnPvC.Text = "Chơi với máy";
            this.btnPvC.UseVisualStyleBackColor = true;
            this.btnPvC.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 97);
            this.button1.TabIndex = 3;
            this.button1.Text = "MultiPlay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 97);
            this.button3.TabIndex = 6;
            this.button3.Text = "Chơi với người";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::caro.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(55, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 248);
            this.panel1.TabIndex = 5;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 612);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPvC);
            this.Controls.Add(this.button1);
            this.Name = "FormIndex";
            this.Text = "Chọn chế độ chơi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPvC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}