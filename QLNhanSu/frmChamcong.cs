using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace QLNhanSu
{
    public partial class txbChamcong : Form
    {

        string Status = "";
        int Index = -1;
        string fileName = "chamCong.xml";


        DataTable dataTableWrite1 = new DataTable();
        DataTable dataTableRead1 = new DataTable();

        DataSet dataSetWrite1 = new DataSet();
        DataSet dataSetRead1 = new DataSet();
        public txbChamcong()
        {
            InitializeComponent();
        }

        void CreateColumnForDataGridView()
        {
            var colCode = new DataGridViewTextBoxColumn();
            var colName = new DataGridViewTextBoxColumn();
            var colTinhTrang = new DataGridViewTextBoxColumn();
            var colCheckInTime = new DataGridViewTextBoxColumn();
            var colCheckOutTime = new DataGridViewTextBoxColumn();

            colCode.HeaderText = "CCCD";
            colName.HeaderText = "Họ tên";
            colTinhTrang.HeaderText = "Tình Trạng";
            colCheckInTime.HeaderText = "CheckIn";
            colCheckOutTime.HeaderText = "CheckOut";

            colCode.DataPropertyName = "Code";
            colName.DataPropertyName = "Name";
            colTinhTrang.DataPropertyName = "Tình Trạng";
            colCheckInTime.DataPropertyName = "CheckIn";
            colCheckOutTime.DataPropertyName = "CheckOut";

            colCode.Width = 120;
            colName.Width = 220;
            colTinhTrang.Width = 120;
            colCheckInTime.Width = 120;
            colCheckOutTime.Width = 120;

            dtgvCongBook.Columns.AddRange(new DataGridViewTextBoxColumn[] { colCode, colName, colTinhTrang, colCheckInTime, colCheckOutTime });
        }
        private void LoadListCongBook()
        {
            dtgvCongBook.DataSource = null;
            CreateColumnForDataGridView();
            dtgvCongBook.DataSource = listCongBook.Instance.listCNV;
            dtgvCongBook.Refresh();

        }

        void EnableControls(bool isEnableTextBox, bool isEnableDataGridWiew)
        {
            TxbCode.Enabled = TxbName.Enabled = TxbTinhTrang.Enabled = TxbCheckInTime.Enabled = TxbCheckOutTime.Enabled = isEnableTextBox;
            dtgvCongBook.Enabled = isEnableDataGridWiew;
        }

        void ClearTextBox()
        {
            foreach (var item in this.Controls)
            {
                TextBox item1 = item as TextBox;
                if (item1 != null)
                {
                    item1.Clear();
                }
            }
        }

        DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable();

            DataColumn colCode = new DataColumn("Code");
            DataColumn colName = new DataColumn("Name");
            DataColumn colTinhTrang = new DataColumn("Tính Trạng");
            DataColumn colCheckInTime = new DataColumn("CheckInTime");
            DataColumn colCheckOutTime = new DataColumn("CheckOutTime");
           

            dataTable.Columns.Add(colCode);
            dataTable.Columns.Add(colName);
            dataTable.Columns.Add(colTinhTrang);
            dataTable.Columns.Add(colCheckInTime);
            dataTable.Columns.Add(colCheckOutTime);
            
            return dataTable;
        }

        void WriteXMLChamCong()
        {
            try
            {
                dataTableWrite1 = CreateDataTable();

                foreach (var item in listCongBook.Instance.listCNV)
                {
                    dataTableWrite1.Rows.Add(item.Code, item.Name, item.TinhTrang, item.CheckInTime, item.CheckOutTime);
                }

                dataSetWrite1.Tables.Add(dataTableWrite1);
                dataSetWrite1.WriteXml(fileName);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Xử lý khi không tìm thấy tệp tin
                Console.WriteLine("Không tìm thấy tệp tin: " + ex.Message);
            }
            catch (System.Xml.XmlException ex)
            {
                // Xử lý khi có lỗi với cú pháp XML
                Console.WriteLine("Lỗi cú pháp XML: " + ex.Message);
            }
        }

        void ReadXMLChamCong()
        {
            try
            {
                dataSetRead1.ReadXml(fileName);
                dataTableRead1 = dataSetRead1.Tables[0];

                foreach (DataRow item in dataTableRead1.Rows)
                {
                    CongBook newCongBook = new CongBook(item);
                    listCongBook.Instance.listCNV.Add(newCongBook);
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Xử lý khi không tìm thấy tệp tin
                Console.WriteLine("Không tìm thấy tệp tin: " + ex.Message);
            }
            catch (System.Xml.XmlException ex)
            {
                // Xử lý khi có lỗi với cú pháp XML
                Console.WriteLine("Lỗi cú pháp XML: " + ex.Message);
            }
        }

        private void txbChamcong_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteXMLChamCong();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmChamcong_Load(object sender, EventArgs e)
        {
            EnableControls(false, true);

            ReadXMLChamCong();

            LoadListCongBook();


           
        }

        // btnChon
        private void button2_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            Status = "Add";
            btnLuu.Enabled = true;
            button2.Enabled = false;

        }

        // btnXoa
        private void button1_Click(object sender, EventArgs e)
        {
            if (Index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            listCongBook.Instance.listCNV.RemoveAt(Index);
            LoadListCongBook();
        }

        //btnLuu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string code = TxbCode.Text;
            string name = TxbName.Text;
            string tinhTrang = TxbTinhTrang.Text;
            string checkInTime = TxbCheckInTime.Text;
            string checkOutTime = TxbCheckOutTime.Text;

            if (Status == "Add")
            {
                listCongBook.Instance.listCNV.Add(new CongBook(code, name, tinhTrang, checkInTime, checkOutTime));
                MessageBox.Show("Chấm công thành công", "Xin cảm ơn");
            }

            EnableControls(false, true);
            LoadListCongBook();
            ClearTextBox();
            btnLuu.Enabled = false;
            button1.Enabled = button2.Enabled = true;
        }

        //lbChonngay
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Datetimechon
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            MessageBox.Show("" + selectedDate.ToString());
        }
       
        //Lay index khi click
        private void dtgvCongBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
