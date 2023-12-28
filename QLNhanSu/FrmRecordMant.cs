using QLNhanSu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class TxbEmployeeCode : Form
    {

        string Status = "";
        int Index = -1;
        string fileName = "nhanVien.xml";

        DataTable dataTableWrite1 = new DataTable();
        DataTable dataTableRead1 = new DataTable();

        DataSet dataSetWrite1 = new DataSet();
        DataSet dataSetRead1 = new DataSet();
        public TxbEmployeeCode()
        {
            InitializeComponent();
        }
        // Create cot
        #region Method
        void CreateColumnForDataGridView()
        {
            var colCode = new DataGridViewTextBoxColumn();
            var colName = new DataGridViewTextBoxColumn();
            var colDateOfBirth = new DataGridViewTextBoxColumn();
            var colPosition = new DataGridViewTextBoxColumn();
            var colAddress = new DataGridViewTextBoxColumn();
            var colNumberPhone = new DataGridViewTextBoxColumn();

            colCode.HeaderText = "CCCD";
            colName.HeaderText = "Họ tên";
            colDateOfBirth.HeaderText = "Ngày sinh";
            colPosition.HeaderText = "Chức vụ";
            colAddress.HeaderText = "Địa chỉ";
            colNumberPhone.HeaderText = "SĐT";


            colCode.DataPropertyName = "Code";
            colName.DataPropertyName = "Name";
            colDateOfBirth.DataPropertyName = "DateOfBirth";
            colPosition.DataPropertyName = "Position";
            colAddress.DataPropertyName = "Address";
            colNumberPhone.DataPropertyName = "NumberPhone";

            colCode.Width = 120;
            colName.Width = 220;
            colDateOfBirth.Width = 120;
            colPosition.Width = 120;
            colAddress.Width = 150;
            colNumberPhone.Width = 200;

            dtgvEmbook.Columns.AddRange(new DataGridViewTextBoxColumn[] { colCode, colName, colDateOfBirth, colPosition, colAddress, colNumberPhone });
        }
        void LoadListEmBook()
        {
            dtgvEmbook.DataSource = null;
            CreateColumnForDataGridView();
            dtgvEmbook.DataSource = ListEmBook.Instance.listEm;
            dtgvEmbook.Refresh();
        }
        // Dkien dtgv and textbox
        void EnableControls(bool isEnableTextBox, bool isEnableDataGridWiew)
        {
            TxbCode.Enabled = TxbName.Enabled = TxbDateOfBirth.Enabled = TxbPosition.Enabled = TxbAddress.Enabled = TxbNumberPhone.Enabled = isEnableTextBox;
            dtgvEmbook.Enabled = isEnableDataGridWiew;
        }
        #endregion

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
            DataColumn colDateOfBrith = new DataColumn("DateOfBrith");
            DataColumn colPosition = new DataColumn("Position");
            DataColumn colAddress = new DataColumn("Address");
            DataColumn colNumberPhone = new DataColumn("NumberPhone");


            dataTable.Columns.Add(colCode);
            dataTable.Columns.Add(colName);
            dataTable.Columns.Add(colDateOfBrith);
            dataTable.Columns.Add(colPosition);
            dataTable.Columns.Add(colAddress);
            dataTable.Columns.Add(colNumberPhone);

            return dataTable;
        }
        void WriteXMLNhanVien()
        {
            try
            {
                dataTableWrite1 = CreateDataTable();

                foreach (var item in ListEmBook.Instance.listEm)
                {
                    dataTableWrite1.Rows.Add(item.Code, item.Name, item.DateOfBrith, item.Position, item.Address, item.NumberPhone);
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

        void ReadXMLNhanVien()
        {
            try
            {
                dataSetRead1.ReadXml(fileName);
                dataTableRead1 = dataSetRead1.Tables[0];

                foreach (DataRow item in dataTableRead1.Rows)
                {
                    Embook newEmbook = new Embook(item);
                    ListEmBook.Instance.listEm.Add(newEmbook);
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
        #region Event

        private void TxbEmployeeCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteXMLNhanVien();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //FormLoad
        private void FrmRecordMant_Load(object sender, EventArgs e)
        {
            EnableControls(false, true);

            ReadXMLNhanVien();

            LoadListEmBook();

            button4.Enabled = button5.Enabled = false;
        }

        // btnAdd(them)
        private void button1_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            Status = "Add";
            button5.Enabled = button4.Enabled = true;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
        }


        //btnEdit(sua)
        private void button2_Click(object sender, EventArgs e)
        {
            Status = "Edit";
            if (Index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }

            EnableControls(true, false);
            button5.Enabled = button4.Enabled = true;
            button1.Enabled = button2.Enabled = button3.Enabled = false;

            //Load txb len textbox
            TxbCode.Text = ListEmBook.Instance.listEm[Index].Code;
            TxbName.Text = ListEmBook.Instance.listEm[Index].Name;
            TxbDateOfBirth.Text = ListEmBook.Instance.listEm[Index].DateOfBrith;
            TxbPosition.Text = ListEmBook.Instance.listEm[Index].Position;
            TxbAddress.Text = ListEmBook.Instance.listEm[Index].Address;
            TxbNumberPhone.Text = ListEmBook.Instance.listEm[Index].NumberPhone;

        }

        //btnHuy
        private void button5_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            EnableControls(false, true);
            button5.Enabled = button4.Enabled = false;
            button1.Enabled = button2.Enabled = button3.Enabled = true;
        }

        //btn(xoa)
        private void button3_Click(object sender, EventArgs e)
        {
            if (Index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            ListEmBook.Instance.listEm.RemoveAt(Index);
            LoadListEmBook();
        }



        //btnSave(luu)
        private void button4_Click(object sender, EventArgs e)
        {
            string code = TxbCode.Text;
            string name = TxbName.Text;
            string date = TxbDateOfBirth.Text;
            string position = TxbPosition.Text;
            string address = TxbAddress.Text;
            string number = TxbNumberPhone.Text;


            if (Status == "Add")
            {
                ListEmBook.Instance.listEm.Add(new Embook(code, name, date, position, address, number));
            }

            if (Status == "Edit")
            {
                ListEmBook.Instance.listEm[Index].Code = TxbCode.Text;
                ListEmBook.Instance.listEm[Index].Name = TxbName.Text;
                ListEmBook.Instance.listEm[Index].DateOfBrith = TxbDateOfBirth.Text;
                ListEmBook.Instance.listEm[Index].Position = TxbPosition.Text;
                ListEmBook.Instance.listEm[Index].Address = TxbAddress.Text;
                ListEmBook.Instance.listEm[Index].NumberPhone = TxbNumberPhone.Text;
            }

            EnableControls(false, true);
            LoadListEmBook();
            ClearTextBox();
            button5.Enabled = button4.Enabled = false;
            button1.Enabled = button2.Enabled = button3.Enabled = true;
        }

        //Lay index khi click
        private void dtgvEmbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        #endregion










        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
