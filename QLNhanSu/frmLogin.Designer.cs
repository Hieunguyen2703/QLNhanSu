namespace QLNhanSu
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            btExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 182);
            label1.Name = "label1";
            label1.Size = new Size(430, 31);
            label1.TabIndex = 1;
            label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN  SỰ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(386, 246);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(390, 308);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaikhoan.Location = new Point(555, 245);
            txtTaikhoan.Margin = new Padding(3, 2, 3, 2);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(252, 29);
            txtTaikhoan.TabIndex = 4;
            txtTaikhoan.TextChanged += textBox1_TextChanged;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhau.Location = new Point(555, 307);
            txtMatkhau.Margin = new Padding(3, 2, 3, 2);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(252, 29);
            txtMatkhau.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(318, 378);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btExit
            // 
            btExit.BackColor = SystemColors.GradientActiveCaption;
            btExit.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btExit.ForeColor = Color.Red;
            btExit.Location = new Point(826, 378);
            btExit.Margin = new Padding(3, 2, 3, 2);
            btExit.Name = "btExit";
            btExit.Size = new Size(68, 33);
            btExit.TabIndex = 7;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 453);
            Controls.Add(btExit);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Button btExit;
    }
}