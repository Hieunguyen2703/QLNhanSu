namespace QLNhanSu
{
    partial class frmHopDongLaoDongcs
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
            panel1 = new Panel();
            dtgThongTin = new DataGridView();
            panel2 = new Panel();
            txbNgayKy = new TextBox();
            txbNgayKT = new TextBox();
            txbNgayBD = new TextBox();
            txbMaNV = new TextBox();
            button5 = new Button();
            txbMaHD = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            btHuy = new Button();
            btLuu = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgThongTin).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgThongTin);
            panel1.Location = new Point(-3, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 214);
            panel1.TabIndex = 1;
            // 
            // dtgThongTin
            // 
            dtgThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThongTin.Location = new Point(5, 12);
            dtgThongTin.Name = "dtgThongTin";
            dtgThongTin.RowTemplate.Height = 25;
            dtgThongTin.Size = new Size(794, 199);
            dtgThongTin.TabIndex = 0;
            dtgThongTin.CellClick += dtgThongTin_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbNgayKy);
            panel2.Controls.Add(txbNgayKT);
            panel2.Controls.Add(txbNgayBD);
            panel2.Controls.Add(txbMaNV);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(txbMaHD);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-3, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 170);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // txbNgayKy
            // 
            txbNgayKy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNgayKy.Location = new Point(570, 22);
            txbNgayKy.Name = "txbNgayKy";
            txbNgayKy.Size = new Size(100, 29);
            txbNgayKy.TabIndex = 18;
            // 
            // txbNgayKT
            // 
            txbNgayKT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNgayKT.Location = new Point(175, 119);
            txbNgayKT.Name = "txbNgayKT";
            txbNgayKT.Size = new Size(100, 29);
            txbNgayKT.TabIndex = 17;
            // 
            // txbNgayBD
            // 
            txbNgayBD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNgayBD.Location = new Point(175, 72);
            txbNgayBD.Name = "txbNgayBD";
            txbNgayBD.Size = new Size(100, 29);
            txbNgayBD.TabIndex = 16;
            // 
            // txbMaNV
            // 
            txbMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbMaNV.Location = new Point(570, 70);
            txbMaNV.Name = "txbMaNV";
            txbMaNV.Size = new Size(100, 29);
            txbMaNV.TabIndex = 15;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(453, 69);
            button5.Name = "button5";
            button5.Size = new Size(75, 30);
            button5.TabIndex = 14;
            button5.Text = "Mã NV";
            button5.UseVisualStyleBackColor = true;
            // 
            // txbMaHD
            // 
            txbMaHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbMaHD.Location = new Point(175, 21);
            txbMaHD.Name = "txbMaHD";
            txbMaHD.Size = new Size(100, 29);
            txbMaHD.TabIndex = 10;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(77, 70);
            button4.Name = "button4";
            button4.Size = new Size(92, 30);
            button4.TabIndex = 9;
            button4.Text = "Ngày BD";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(77, 117);
            button3.Name = "button3";
            button3.Size = new Size(92, 30);
            button3.TabIndex = 8;
            button3.Text = "Ngày KT";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(453, 21);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 7;
            button2.Text = "Ngày Ký";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(77, 21);
            button1.Name = "button1";
            button1.Size = new Size(92, 30);
            button1.TabIndex = 6;
            button1.Text = "Mã HD";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btHuy);
            panel3.Controls.Add(btLuu);
            panel3.Controls.Add(btXoa);
            panel3.Controls.Add(btSua);
            panel3.Controls.Add(btThem);
            panel3.Location = new Point(2, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 43);
            panel3.TabIndex = 3;
            // 
            // btHuy
            // 
            btHuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btHuy.Location = new Point(448, 5);
            btHuy.Name = "btHuy";
            btHuy.Size = new Size(75, 30);
            btHuy.TabIndex = 3;
            btHuy.Text = "Hủy";
            btHuy.UseVisualStyleBackColor = true;
            btHuy.Click += btHuy_Click;
            // 
            // btLuu
            // 
            btLuu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btLuu.Location = new Point(328, 5);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 30);
            btLuu.TabIndex = 2;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btXoa
            // 
            btXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btXoa.Location = new Point(206, 5);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(75, 30);
            btXoa.TabIndex = 1;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btSua.Location = new Point(109, 5);
            btSua.Name = "btSua";
            btSua.Size = new Size(75, 30);
            btSua.TabIndex = 1;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThem
            // 
            btThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btThem.Location = new Point(10, 6);
            btThem.Name = "btThem";
            btThem.Size = new Size(75, 30);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // frmHopDongLaoDongcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmHopDongLaoDongcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHopDongLaoDongcs";
            FormClosing += frmHopDongLaoDongcs_FormClosing;
            Load += frmHopDongLaoDongcs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgThongTin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btThem;
        private TextBox txbMaHD;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btHuy;
        private Button btLuu;
        private Button btXoa;
        private Button btSua;
        private DataGridView dtgThongTin;
        private TextBox txbMaNV;
        private Button button5;
        private TextBox txbNgayKy;
        private TextBox txbNgayKT;
        private TextBox txbNgayBD;
    }
}