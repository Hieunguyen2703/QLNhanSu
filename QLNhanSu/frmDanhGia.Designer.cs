namespace QLNhanSu
{
    partial class frmDanhGia
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
            txbTenNhanVien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbMaNhanVien = new TextBox();
            txbSoTien = new TextBox();
            dtgDanhGia = new DataGridView();
            txbLiDo = new TextBox();
            btSua = new Button();
            btLuu = new Button();
            btThem = new Button();
            btXoa = new Button();
            btHuy = new Button();
            label4 = new Label();
            txbTenLoai = new TextBox();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            danhMujcToolStripMenuItem = new ToolStripMenuItem();
            thôngTinHồSơToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgDanhGia).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txbTenNhanVien
            // 
            txbTenNhanVien.Location = new Point(186, 50);
            txbTenNhanVien.Name = "txbTenNhanVien";
            txbTenNhanVien.Size = new Size(100, 23);
            txbTenNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 92);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 2;
            label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 3;
            label3.Text = "Số tiền";
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.Location = new Point(186, 92);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.Size = new Size(100, 23);
            txbMaNhanVien.TabIndex = 5;
            // 
            // txbSoTien
            // 
            txbSoTien.Location = new Point(186, 134);
            txbSoTien.Name = "txbSoTien";
            txbSoTien.Size = new Size(100, 23);
            txbSoTien.TabIndex = 6;
            // 
            // dtgDanhGia
            // 
            dtgDanhGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhGia.Location = new Point(-1, 255);
            dtgDanhGia.Name = "dtgDanhGia";
            dtgDanhGia.RowTemplate.Height = 25;
            dtgDanhGia.Size = new Size(999, 233);
            dtgDanhGia.TabIndex = 7;
            dtgDanhGia.CellClick += dtgDanhGia_CellClick;
            // 
            // txbLiDo
            // 
            txbLiDo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txbLiDo.Location = new Point(529, 54);
            txbLiDo.Multiline = true;
            txbLiDo.Name = "txbLiDo";
            txbLiDo.Size = new Size(309, 158);
            txbLiDo.TabIndex = 8;
            // 
            // btSua
            // 
            btSua.Location = new Point(878, 68);
            btSua.Name = "btSua";
            btSua.Size = new Size(75, 23);
            btSua.TabIndex = 9;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(878, 168);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 23);
            btLuu.TabIndex = 10;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(878, 27);
            btThem.Name = "btThem";
            btThem.Size = new Size(75, 23);
            btThem.TabIndex = 11;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(878, 116);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 23);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btHuy
            // 
            btHuy.Location = new Point(878, 211);
            btHuy.Name = "btHuy";
            btHuy.Size = new Size(75, 23);
            btHuy.TabIndex = 13;
            btHuy.Text = "Hủy";
            btHuy.UseVisualStyleBackColor = true;
            btHuy.Click += btHuy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 179);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 14;
            label4.Text = "Tên loại";
            // 
            // txbTenLoai
            // 
            txbTenLoai.Location = new Point(186, 183);
            txbTenLoai.Name = "txbTenLoai";
            txbTenLoai.Size = new Size(100, 23);
            txbTenLoai.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(446, 46);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 16;
            label5.Text = "Lí do";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhMujcToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhMujcToolStripMenuItem
            // 
            danhMujcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinHồSơToolStripMenuItem, thoátToolStripMenuItem });
            danhMujcToolStripMenuItem.Name = "danhMujcToolStripMenuItem";
            danhMujcToolStripMenuItem.Size = new Size(83, 20);
            danhMujcToolStripMenuItem.Text = "DANH MỤC";
            // 
            // thôngTinHồSơToolStripMenuItem
            // 
            thôngTinHồSơToolStripMenuItem.Name = "thôngTinHồSơToolStripMenuItem";
            thôngTinHồSơToolStripMenuItem.Size = new Size(180, 22);
            thôngTinHồSơToolStripMenuItem.Text = "Thông tin hồ sơ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(180, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // frmDanhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 500);
            Controls.Add(menuStrip1);
            Controls.Add(label5);
            Controls.Add(txbTenLoai);
            Controls.Add(label4);
            Controls.Add(btHuy);
            Controls.Add(btXoa);
            Controls.Add(btThem);
            Controls.Add(btLuu);
            Controls.Add(btSua);
            Controls.Add(txbLiDo);
            Controls.Add(dtgDanhGia);
            Controls.Add(txbSoTien);
            Controls.Add(txbMaNhanVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbTenNhanVien);
            Name = "frmDanhGia";
            FormClosing += frmDanhGia_FormClosing;
            Load += frmDanhGia_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhGia).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbTenNhanVien;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbMaNhanVien;
        private TextBox txbSoTien;
        private DataGridView dtgDanhGia;
        private TextBox txbLiDo;
        private Button btSua;
        private Button btLuu;
        private Button btThem;
        private Button btXoa;
        private Button btHuy;
        private Label label4;
        private TextBox txbTenLoai;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMujcToolStripMenuItem;
        private ToolStripMenuItem thôngTinHồSơToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}