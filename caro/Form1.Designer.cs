namespace caro
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnChếĐộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerLANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.prgTimeLine = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbDaiDien = new System.Windows.Forms.PictureBox();
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDaiDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem1,
            this.chọnChếĐộToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem1
            // 
            this.undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            this.undoToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.undoToolStripMenuItem1.Text = "Undo";
            this.undoToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem1_Click);
            // 
            // chọnChếĐộToolStripMenuItem
            // 
            this.chọnChếĐộToolStripMenuItem.Name = "chọnChếĐộToolStripMenuItem";
            this.chọnChếĐộToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.chọnChếĐộToolStripMenuItem.Text = "Chọn chế độ";
            this.chọnChếĐộToolStripMenuItem.Click += new System.EventHandler(this.chọnChếĐộToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // playerLANToolStripMenuItem
            // 
            this.playerLANToolStripMenuItem.Name = "playerLANToolStripMenuItem";
            this.playerLANToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.prgTimeLine);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ptbDaiDien);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lượt đi";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(92, 58);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "label2";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(6, 157);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(186, 19);
            this.txtIP.TabIndex = 4;
            // 
            // prgTimeLine
            // 
            this.prgTimeLine.Location = new System.Drawing.Point(6, 110);
            this.prgTimeLine.Name = "prgTimeLine";
            this.prgTimeLine.Size = new System.Drawing.Size(186, 23);
            this.prgTimeLine.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người chơi";
            // 
            // ptbDaiDien
            // 
            this.ptbDaiDien.Location = new System.Drawing.Point(6, 31);
            this.ptbDaiDien.Name = "ptbDaiDien";
            this.ptbDaiDien.Size = new System.Drawing.Size(67, 63);
            this.ptbDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDaiDien.TabIndex = 0;
            this.ptbDaiDien.TabStop = false;
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.Location = new System.Drawing.Point(229, 40);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(670, 585);
            this.pnlBanCo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::caro.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 639);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDaiDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar prgTimeLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbDaiDien;
        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerLANToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chọnChếĐộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

