namespace QLNhanSu
{
    partial class TxbEmployeeCode
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
            TxbDateOfBirth = new TextBox();
            TxbAddress = new TextBox();
            TxbCode = new TextBox();
            TxbName = new TextBox();
            TxbNumberPhone = new TextBox();
            TxbPosition = new TextBox();
            dtgvEmbook = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            danhMujcToolStripMenuItem = new ToolStripMenuItem();
            thôngTinHồSơToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgvEmbook).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TxbDateOfBirth
            // 
            TxbDateOfBirth.Location = new Point(945, 36);
            TxbDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            TxbDateOfBirth.Multiline = true;
            TxbDateOfBirth.Name = "TxbDateOfBirth";
            TxbDateOfBirth.Size = new Size(195, 26);
            TxbDateOfBirth.TabIndex = 0;
            TxbDateOfBirth.TextChanged += textBox1_TextChanged;
            // 
            // TxbAddress
            // 
            TxbAddress.Location = new Point(532, 124);
            TxbAddress.Margin = new Padding(3, 2, 3, 2);
            TxbAddress.Multiline = true;
            TxbAddress.Name = "TxbAddress";
            TxbAddress.Size = new Size(195, 26);
            TxbAddress.TabIndex = 1;
            // 
            // TxbCode
            // 
            TxbCode.Location = new Point(127, 38);
            TxbCode.Margin = new Padding(3, 2, 3, 2);
            TxbCode.Multiline = true;
            TxbCode.Name = "TxbCode";
            TxbCode.Size = new Size(195, 27);
            TxbCode.TabIndex = 2;
            TxbCode.TextChanged += textBox3_TextChanged;
            // 
            // TxbName
            // 
            TxbName.Location = new Point(532, 38);
            TxbName.Margin = new Padding(3, 2, 3, 2);
            TxbName.Multiline = true;
            TxbName.Name = "TxbName";
            TxbName.Size = new Size(195, 26);
            TxbName.TabIndex = 3;
            TxbName.TextChanged += textBox4_TextChanged;
            // 
            // TxbNumberPhone
            // 
            TxbNumberPhone.Location = new Point(954, 124);
            TxbNumberPhone.Margin = new Padding(3, 2, 3, 2);
            TxbNumberPhone.Multiline = true;
            TxbNumberPhone.Name = "TxbNumberPhone";
            TxbNumberPhone.Size = new Size(195, 26);
            TxbNumberPhone.TabIndex = 4;
            // 
            // TxbPosition
            // 
            TxbPosition.Location = new Point(127, 124);
            TxbPosition.Margin = new Padding(3, 2, 3, 2);
            TxbPosition.Multiline = true;
            TxbPosition.Name = "TxbPosition";
            TxbPosition.Size = new Size(195, 26);
            TxbPosition.TabIndex = 5;
            // 
            // dtgvEmbook
            // 
            dtgvEmbook.BackgroundColor = SystemColors.ControlLightLight;
            dtgvEmbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmbook.Location = new Point(18, 169);
            dtgvEmbook.Margin = new Padding(3, 2, 3, 2);
            dtgvEmbook.Name = "dtgvEmbook";
            dtgvEmbook.RowHeadersWidth = 51;
            dtgvEmbook.RowTemplate.Height = 29;
            dtgvEmbook.Size = new Size(1121, 235);
            dtgvEmbook.TabIndex = 6;
            dtgvEmbook.CellClick += dtgvEmbook_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 40);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 7;
            label1.Text = "Mã NV(CCCD)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(429, 42);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(816, 42);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 9;
            label3.Text = "Ngày sinh";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 129);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 10;
            label4.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(427, 129);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(802, 129);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 12;
            label6.Text = "Số điện thoại";
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(18, 446);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 13;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(127, 446);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(97, 29);
            button2.TabIndex = 14;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(241, 446);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(97, 29);
            button3.TabIndex = 15;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(352, 446);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(97, 29);
            button4.TabIndex = 16;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(467, 446);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(97, 29);
            button5.TabIndex = 17;
            button5.Text = "Hủy";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhMujcToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1158, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            thôngTinHồSơToolStripMenuItem.Size = new Size(157, 22);
            thôngTinHồSơToolStripMenuItem.Text = "Thông tin hồ sơ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(157, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // TxbEmployeeCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 502);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgvEmbook);
            Controls.Add(TxbPosition);
            Controls.Add(TxbNumberPhone);
            Controls.Add(TxbName);
            Controls.Add(TxbCode);
            Controls.Add(TxbAddress);
            Controls.Add(TxbDateOfBirth);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TxbEmployeeCode";
            Text = "FrmRecordMant";
            FormClosing += TxbEmployeeCode_FormClosing;
            Load += FrmRecordMant_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvEmbook).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxbDateOfBirth;
        private TextBox TxbAddress;
        private TextBox TxbCode;
        private TextBox TxbName;
        private TextBox TxbNumberPhone;
        private TextBox TxbPosition;
        private DataGridView dtgvEmbook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMujcToolStripMenuItem;
        private ToolStripMenuItem thôngTinHồSơToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
    }
}