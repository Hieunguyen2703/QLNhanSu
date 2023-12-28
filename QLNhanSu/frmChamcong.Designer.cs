namespace QLNhanSu
{
    partial class txbChamcong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbCheckOutTime = new System.Windows.Forms.TextBox();
            this.TxbCheckInTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbTinhTrang = new System.Windows.Forms.TextBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbCode = new System.Windows.Forms.TextBox();
            this.dtgvCongBook = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxbCheckOutTime);
            this.panel1.Controls.Add(this.TxbCheckInTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxbTinhTrang);
            this.panel1.Controls.Add(this.TxbName);
            this.panel1.Controls.Add(this.TxbCode);
            this.panel1.Controls.Add(this.dtgvCongBook);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 499);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(365, 558);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Check";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(376, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giờ về";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giờ đến";
            // 
            // TxbCheckOutTime
            // 
            this.TxbCheckOutTime.Location = new System.Drawing.Point(476, 90);
            this.TxbCheckOutTime.Multiline = true;
            this.TxbCheckOutTime.Name = "TxbCheckOutTime";
            this.TxbCheckOutTime.Size = new System.Drawing.Size(104, 35);
            this.TxbCheckOutTime.TabIndex = 12;
            // 
            // TxbCheckInTime
            // 
            this.TxbCheckInTime.Location = new System.Drawing.Point(98, 90);
            this.TxbCheckInTime.Multiline = true;
            this.TxbCheckInTime.Name = "TxbCheckInTime";
            this.TxbCheckInTime.Size = new System.Drawing.Size(95, 35);
            this.TxbCheckInTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(698, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tình Trạng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã NV";
            // 
            // TxbTinhTrang
            // 
            this.TxbTinhTrang.Location = new System.Drawing.Point(831, 90);
            this.TxbTinhTrang.Multiline = true;
            this.TxbTinhTrang.Name = "TxbTinhTrang";
            this.TxbTinhTrang.Size = new System.Drawing.Size(100, 35);
            this.TxbTinhTrang.TabIndex = 5;
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(476, 20);
            this.TxbName.Multiline = true;
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(222, 35);
            this.TxbName.TabIndex = 4;
            // 
            // TxbCode
            // 
            this.TxbCode.Location = new System.Drawing.Point(98, 20);
            this.TxbCode.Multiline = true;
            this.TxbCode.Name = "TxbCode";
            this.TxbCode.Size = new System.Drawing.Size(222, 35);
            this.TxbCode.TabIndex = 3;
            this.TxbCode.TextChanged += new System.EventHandler(this.TxbCode_TextChanged);
            // 
            // dtgvCongBook
            // 
            this.dtgvCongBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvCongBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongBook.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvCongBook.Location = new System.Drawing.Point(103, 159);
            this.dtgvCongBook.Name = "dtgvCongBook";
            this.dtgvCongBook.RowHeadersWidth = 51;
            this.dtgvCongBook.RowTemplate.Height = 29;
            this.dtgvCongBook.Size = new System.Drawing.Size(860, 321);
            this.dtgvCongBook.TabIndex = 0;
            this.dtgvCongBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chọn ngày";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 555);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 27);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.Location = new System.Drawing.Point(599, 543);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 39);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(736, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(462, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Chọn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 597);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "txbChamcong";
            this.Text = "frmChamcong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dtgvCongBook;
        private TextBox TxbTinhTrang;
        private TextBox TxbName;
        private TextBox TxbCode;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button btnLuu;
        private Button button1;
        private Label label6;
        private Label label5;
        private TextBox TxbCheckOutTime;
        private TextBox TxbCheckInTime;
        private Button button2;
        private CheckBox checkBox1;
    }
}