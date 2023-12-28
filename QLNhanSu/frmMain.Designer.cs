namespace QLNhanSu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnsMain = new MenuStrip();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            phòngBanToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHồSơToolStripMenuItem = new ToolStripMenuItem();
            khaiBáoHồSơNhânSựToolStripMenuItem = new ToolStripMenuItem();
            quảnLýHĐLĐToolStripMenuItem = new ToolStripMenuItem();
            khaiBáoThôngTinHĐLĐToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            chấmCôngToolStripMenuItem = new ToolStripMenuItem();
            xemBảngLươngToolStripMenuItem = new ToolStripMenuItem();
            đánhGiáToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { danhMụcToolStripMenuItem, quảnLýHồSơToolStripMenuItem, quảnLýHĐLĐToolStripMenuItem, quảnLýToolStripMenuItem });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Padding = new Padding(5, 2, 0, 2);
            mnsMain.Size = new Size(1164, 24);
            mnsMain.TabIndex = 0;
            mnsMain.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chứcVụToolStripMenuItem, phòngBanToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(71, 20);
            danhMụcToolStripMenuItem.Text = "Hệ Thống";
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(190, 22);
            chứcVụToolStripMenuItem.Text = "Thông tin người dùng";
            chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
            // 
            // phòngBanToolStripMenuItem
            // 
            phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            phòngBanToolStripMenuItem.Size = new Size(190, 22);
            phòngBanToolStripMenuItem.Text = "Đăng xuất";
            phòngBanToolStripMenuItem.Click += phòngBanToolStripMenuItem_Click;
            // 
            // quảnLýHồSơToolStripMenuItem
            // 
            quảnLýHồSơToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khaiBáoHồSơNhânSựToolStripMenuItem });
            quảnLýHồSơToolStripMenuItem.Name = "quảnLýHồSơToolStripMenuItem";
            quảnLýHồSơToolStripMenuItem.Size = new Size(97, 20);
            quảnLýHồSơToolStripMenuItem.Text = "Quản Lý Hồ Sơ";
            // 
            // khaiBáoHồSơNhânSựToolStripMenuItem
            // 
            khaiBáoHồSơNhânSựToolStripMenuItem.Name = "khaiBáoHồSơNhânSựToolStripMenuItem";
            khaiBáoHồSơNhânSựToolStripMenuItem.Size = new Size(197, 22);
            khaiBáoHồSơNhânSựToolStripMenuItem.Text = "Khai báo hồ sơ nhân sự";
            khaiBáoHồSơNhânSựToolStripMenuItem.Click += khaiBáoHồSơNhânSựToolStripMenuItem_Click;
            // 
            // quảnLýHĐLĐToolStripMenuItem
            // 
            quảnLýHĐLĐToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khaiBáoThôngTinHĐLĐToolStripMenuItem });
            quảnLýHĐLĐToolStripMenuItem.Name = "quảnLýHĐLĐToolStripMenuItem";
            quảnLýHĐLĐToolStripMenuItem.Size = new Size(96, 20);
            quảnLýHĐLĐToolStripMenuItem.Text = "Quản Lý HĐLĐ";
            // 
            // khaiBáoThôngTinHĐLĐToolStripMenuItem
            // 
            khaiBáoThôngTinHĐLĐToolStripMenuItem.Name = "khaiBáoThôngTinHĐLĐToolStripMenuItem";
            khaiBáoThôngTinHĐLĐToolStripMenuItem.Size = new Size(206, 22);
            khaiBáoThôngTinHĐLĐToolStripMenuItem.Text = "Khai báo thông tin HĐLĐ";
            khaiBáoThôngTinHĐLĐToolStripMenuItem.Click += khaiBáoThôngTinHĐLĐToolStripMenuItem_Click;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chấmCôngToolStripMenuItem, xemBảngLươngToolStripMenuItem, đánhGiáToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(85, 20);
            quảnLýToolStripMenuItem.Text = "Quản lý CnB";
            // 
            // chấmCôngToolStripMenuItem
            // 
            chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            chấmCôngToolStripMenuItem.Size = new Size(162, 22);
            chấmCôngToolStripMenuItem.Text = "Chấm công";
            chấmCôngToolStripMenuItem.Click += chấmCôngToolStripMenuItem_Click;
            // 
            // xemBảngLươngToolStripMenuItem
            // 
            xemBảngLươngToolStripMenuItem.Name = "xemBảngLươngToolStripMenuItem";
            xemBảngLươngToolStripMenuItem.Size = new Size(162, 22);
            xemBảngLươngToolStripMenuItem.Text = "Xem bảng lương";
            xemBảngLươngToolStripMenuItem.Click += xemBảngLươngToolStripMenuItem_Click;
            // 
            // đánhGiáToolStripMenuItem
            // 
            đánhGiáToolStripMenuItem.Name = "đánhGiáToolStripMenuItem";
            đánhGiáToolStripMenuItem.Size = new Size(162, 22);
            đánhGiáToolStripMenuItem.Text = "Đánh giá";
            đánhGiáToolStripMenuItem.Click += đánhGiáToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(94, 39);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(185, 39);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 39);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(273, 222);
            label1.Name = "label1";
            label1.Size = new Size(598, 44);
            label1.TabIndex = 9;
            label1.Text = "PHẦN MỀM QUẢN LÝ NHÂN SỰ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 440);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Sự";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsMain;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem phòngBanToolStripMenuItem;
        private ToolStripMenuItem quảnLýHồSơToolStripMenuItem;
        private ToolStripMenuItem khaiBáoHồSơNhânSựToolStripMenuItem;
        private ToolStripMenuItem quảnLýHĐLĐToolStripMenuItem;
        private ToolStripMenuItem khaiBáoThôngTinHĐLĐToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem chấmCôngToolStripMenuItem;
        private ToolStripMenuItem xemBảngLươngToolStripMenuItem;
        private ToolStripMenuItem đánhGiáToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
    }
}